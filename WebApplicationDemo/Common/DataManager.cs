using Microsoft.Extensions.Configuration;
using NPoco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Common
{
    public class DataManager : Database
    {
        protected static IConfigurationRoot Configuration { get; }
        protected static string connection { get; set; }
        static DataManager()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            connection = Configuration.GetConnectionString("DefaultConnection");
        }

        public DataManager() : base(connection, DatabaseType.Oracle, 
            Oracle.ManagedDataAccess.Client.OracleClientFactory.Instance)
        {

        }
    }
}
