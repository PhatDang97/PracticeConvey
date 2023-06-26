using Convey;
using Convey.HTTP;
using FirstApp.Application.Services;

namespace FirstApp
{
    public static class Extensions
    {
        public static IConveyBuilder AddServices(this IConveyBuilder builder)
        {
            builder.AddHttpClient();
            builder.Services.AddSingleton<AccountsService>();
            return builder;
        }
    }
}
