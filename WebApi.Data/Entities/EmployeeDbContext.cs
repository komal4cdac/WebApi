using Microsoft.EntityFrameworkCore;

namespace WebApi.Data.Entities
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options)
             : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
    }
}
