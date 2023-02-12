using Microsoft.EntityFrameworkCore;
using UserAuthenticationSystem.Models;

namespace UserAuthenticationSystem.Controllers.DbContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}