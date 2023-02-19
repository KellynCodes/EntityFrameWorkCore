using EfCore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.DAL.EfCoreSetup
{
    public class ReliconDbContext : DbContext
    {
        public ReliconDbContext(DbContextOptions<ReliconDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.Property(property => property.TimeStamp).IsRequired(false);
                entity.Property(property => property.Name).IsRequired(true).HasMaxLength(20);
                entity.Property(propery => propery.Description).IsRequired(true).HasMaxLength(400);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(p => p.Name, $"IX_{nameof(Tag)}_{nameof(Tag.Name)}")
                   .IsUnique();
                entity.Property(property => property.Name).IsRequired(true).HasMaxLength(20);
                entity.Property(property => property.Description).IsRequired(true).HasMaxLength(500);
                entity.Property(property => property.TimeStamp).IsRequired(false);
            }
            );

            modelBuilder.Entity<User>(entity => {
                entity.Property(property => property.TimeStamp).IsRequired(false);
                entity.Property(property => property.Name).IsRequired(false);
                entity.HasIndex(property => new { property.Email, property.Phone }, $"IX_Unique_{nameof(User.Email)}{nameof(User.Phone)}").IsUnique();
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
