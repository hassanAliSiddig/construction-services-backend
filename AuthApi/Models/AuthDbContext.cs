
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;

namespace AuthApi.Models
{
    public class AuthDbContext: DbContext
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AuthUser>()
                .HasIndex(e => e.Username)
                .IsUnique();

           
            builder.Entity<AuthUser>()
                .HasData(AuthDataSeeding.AdminSetterUsers);
        }

        public DbSet<AuthUser> AuthUsers { get; set; }

    }
}
