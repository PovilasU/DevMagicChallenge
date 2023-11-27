using Microsoft.EntityFrameworkCore;
using TribecaWebAPI.Entities;

namespace TribecaWebAPI.Context
{
    public class TribecaDbContext:DbContext
    {
        public TribecaDbContext(DbContextOptions options): base(options) { }

        public DbSet<Employee> Employees { get; set; }

    }
}
