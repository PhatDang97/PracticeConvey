

// install nuget
// convey swagger
// convey cqrs commands
// Convey.CQRS.Queries
// Convey.WebApi

using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Convey.CQRS.Queries;
using Convey.Docs.Swagger;
using Convey.WebApi;
using Convey.WebApi.Exceptions;
using Convey.WebApi.Swagger;
using FirstApp;
using FirstApp.Application.DTO;
using FirstApp.Application.Events;
using FirstApp.Application.Queries;
using FirstApp.Application.Reqest;

public class Program
{
    //    public static async Task Main(string[] args)
    //        => await WebHost.CreateDefaultBuilder(args)
    //            .ConfigureServices(services => services.AddConvey().Build())
    //            .Configure(app =>
    //            {
    //                //Configure the middleware
    //            })
    //            .Build()
    //            .RunAsync();

    public static async Task Main(string[] args)
        => await CreateHostBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddConvey();
        }).Build().RunAsync();
    
    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.ConfigureServices(services => services
            .AddConvey()
            .AddServices()
            .AddCommandHandlers()
            .AddInMemoryCommandDispatcher()
            .AddQueryHandlers()
            .AddInMemoryQueryDispatcher()
            .AddEventHandlers()
            .AddInMemoryEventDispatcher()
            .AddWebApi()
            .AddSwaggerDocs()
            .AddWebApiSwaggerDocs()
            .Build())
            .Configure(app => app
            .UseConvey()
            .UseRouting()
            .UseEndpoints(enpoints => enpoints
            .Get("", ctx => ctx.Response.WriteAsync("Hello"))
            .Get<GetAccount, AccountDto>("accounts/{accountId}")
            .Get<GetAccounts, IEnumerable<AccountDto>>("accounts")
            .Post<AccountCreated>("accounts", (req, ctx) => ctx.Response.Created($"accounts/{req.Id}"))
            .Delete<DeleteAccount>("accounts/{accountId}"))
            .UseSwaggerDocs()
            .UseHttpsRedirection()
            );
        });
}



//var builder = WebApplication.CreateBuilder(args);

//// Config Swagger Convey
//WebHost.CreateDefaultBuilder(args)
//    .ConfigureServices(services => services
//    .AddConvey()
//    .AddWebApi()
//    .AddWebApiSwaggerDocs()
//    .Build());


//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
