using Employee.Integration.Sql.Connections;
using Microsoft.Extensions.Configuration;
using System;

namespace Employee.Web.Main.Infrastructure
{
    public class DbSettings : IDbSettings
    {
        private readonly IConfiguration _configuration;

        public DbSettings(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public string ConnectionString => _configuration.GetConnectionString("ClientManagerDbConnection");
    }
}
