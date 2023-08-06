using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRUEBA_MINERD_RDUVERGE.Models;

namespace PRUEBA_MINERD_RDUVERGE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<PRUEBA_MINERD_RDUVERGE.Models.Customer> Customer { get; set; } = default!;
    }
}