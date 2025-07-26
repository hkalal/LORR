
using Microsoft.EntityFrameworkCore;
using LrrApp.Models;

namespace LrrApp.Data
{
    public class LrrDbContext : DbContext
    {
        public LrrDbContext(DbContextOptions<LrrDbContext> options) : base(options)
        {
        }

        public DbSet<LrrForm> LrrForms { get; set; }
        public DbSet<RrChecklist> RrChecklists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure LrrForm
            modelBuilder.Entity<LrrForm>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatorName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.ProjectName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.CustomerName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.EstimatedBid).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfBidValue).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfGrossMargin).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfNetMargin).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfWarrantyProv).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfInflation).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfContingencies).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfRiskProv).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfTotalProv).HasColumnType("decimal(18,2)");
                entity.Property(e => e.PfMatCost).HasColumnType("decimal(18,2)");
            });

            // Configure RrChecklist
            modelBuilder.Entity<RrChecklist>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Criteria1).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Criteria2).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Criteria3).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Priority).HasMaxLength(50);
                entity.Property(e => e.Status).HasMaxLength(50);
            });
        }
    }
}
