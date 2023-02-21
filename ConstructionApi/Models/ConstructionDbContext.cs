using Microsoft.EntityFrameworkCore;

namespace ConstructionApi.Models
{
    public class ConstructionDbContext: DbContext
    {
        public ConstructionDbContext(DbContextOptions<ConstructionDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasIndex(e => e.Name)
                .IsUnique();

            builder.Entity<Company>()
               .HasIndex(e => e.Name)
               .IsUnique();

            builder.Entity<ConstructionRequestStatus>()
              .HasIndex(e => e.Name)
              .IsUnique();


            builder.Entity<Client>()
                .HasData(ConstructionDataSeeding.Clients);

            builder.Entity<Company>()
                .HasData(ConstructionDataSeeding.Companies);

            builder.Entity<ConstructionRequestStatus>()
                .HasData(ConstructionDataSeeding.ConstructionRequestStatusList);

            builder.Entity<ProjectStatus>()
                .HasData(ConstructionDataSeeding.ProjectStatusList);

            builder.Entity<Project>()
                .HasData(ConstructionDataSeeding.Projects);

            builder.Entity<Payment>()
               .HasData(ConstructionDataSeeding.Payment);

            builder.Entity<ConstructionRequest>()
               .HasData(ConstructionDataSeeding.constructionRequests);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ConstructionRequestStatus> ConstructionRequestStatuses { get; set; }
        public DbSet<ConstructionRequest> ConstructionRequests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<Project> projects { get; set; }

    }
}
