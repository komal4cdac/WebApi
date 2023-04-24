using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;
using WebApi.Data.MasterEntities;

namespace WebApi.CustomMiddlerwares
{
    public static class ConnectionStringFramer
    {

        public static void LoadConfiguration(this ConfigurationManager manager)
        {
            manager.AddJsonFile("./appsettings.json", optional: true, reloadOnChange: true);
        }
        public static string GetConnectionString(this ConfigurationManager manager)
        {
            string connectionString =  manager.GetSection("ConnectionString:ClientDataBaseConnectionStringFormat").Value;
            var serverData = manager.GetServerData();
            Console.WriteLine(serverData.FirstOrDefault().ServerName);
            return string.Format(connectionString,serverData.First().ServerName, serverData.First().DataBaseName);
        }

        private static IList<ClientServerDatabaseConfiguration> GetServerData(this ConfigurationManager manager)
        {
            List<ClientServerDatabaseConfiguration> clientServerDatabaseConfigurations = new List<ClientServerDatabaseConfiguration>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = manager.GetSection("ConnectionString:MasterDataBaseConnectionStringFormat").Value;
                SqlCommand cmd = new SqlCommand("select * from ClientDbMasterConfiguration", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clientServerDatabaseConfigurations.Add(new ClientServerDatabaseConfiguration((long)reader[0], reader[1].ToString(), reader[2].ToString()));
                }      
                conn.Close();
            }
            return clientServerDatabaseConfigurations;
        }

    }
}
