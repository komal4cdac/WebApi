using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.MasterEntities
{
    public class ClientServerDatabaseConfiguration
    {
        public ClientServerDatabaseConfiguration(long id, string serverName, string dataBaseName )
        {
            Id = id;
            ServerName = serverName;
            DataBaseName = dataBaseName;
            
        }
        public long Id { get; set; }
        public string? ServerName { get; set; }
        public string? DataBaseName { get; set; }

        public string? CreatedDate { get; set; }
    }
}
