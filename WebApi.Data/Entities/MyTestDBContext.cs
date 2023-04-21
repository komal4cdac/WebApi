using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.Entities
{
    
    public class MyTestDBContext : DbContext
    {
        public MyTestDBContext(DbContextOptions options)
             : base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
    }
}
