using IntegracaoOmie.Models;

namespace IntegracaoOmie
{
    public static class Bootstrapper
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration config)
        {
            AdicionarCredencias(services, config);
        }

        private static void AdicionarCredencias(IServiceCollection services, IConfiguration config)
        {
            var app_key = config.GetRequiredSection("Credencias:app_key");
            var app_secret = config.GetRequiredSection("Credencias:app_secret");
            services.AddScoped(option => new RequestBase { app_key = app_key.Value, app_secret = app_secret.Value});
        }

    }
}
