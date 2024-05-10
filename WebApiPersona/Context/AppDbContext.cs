using Microsoft.EntityFrameworkCore;
using WebApiPersona.Model;

namespace WebApiPersona.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
