using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace Api.Data
{

    public class MySqlDbSession : IDbSession, IDisposable
    {
        public IDbConnection Connection { get; }
        private IConfiguration _configuration { get; set; }

        public MySqlDbSession(IConfiguration configuration)
        {
            _configuration = configuration;
            Connection =  new MySql.Data.MySqlClient.MySqlConnection(configuration
                     .GetConnectionString("mycommerce"));
            // Connection.Open();
        }
        public void Dispose() => Connection?.Dispose();
    }
}

