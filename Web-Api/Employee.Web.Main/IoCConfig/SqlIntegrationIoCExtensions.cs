using Employee.Integration.Sql.Connections;
using Employee.Web.Main.Infrastructure;
using Microsoft.Extensions.DependencyInjection;


namespace Employee.Web.Main.IoCConfig
{
    public static class SqlIntegrationIoCExtensions
    {
        public static IServiceCollection AddSqlIntegration(this IServiceCollection services)
        {
            services.AddScoped<IDbSettings, DbSettings>();
            services.AddScoped<IClientManagerDbConnectionContext>(
                provider => new AutoConnectingDbConnectionContext(provider.GetService<IDbSettings>(), settings => settings.ConnectionString)
            );

            return services;
        }
    }
}
