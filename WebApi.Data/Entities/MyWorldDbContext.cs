using Microsoft.EntityFrameworkCore;

namespace WebApi.Data.Entities
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions options)
             : base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
    }
}
