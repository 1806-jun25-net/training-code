using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestaurantReviews.Context.Models
{
    public partial class RestaurantReviewsDBContext : DbContext
    {
        public RestaurantReviewsDBContext()
        {
        }

        public RestaurantReviewsDBContext(DbContextOptions<RestaurantReviewsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<Review> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant", "RR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review", "RR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2048);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Restaurant");
            });
        }
    }
}
