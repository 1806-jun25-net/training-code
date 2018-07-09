using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDBFirstDemo.Data
{
    public partial class MoviesDBContext : DbContext
    {
        public MoviesDBContext()
        {
        }

        public MoviesDBContext(DbContextOptions<MoviesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre", "MoviesDB");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie", "MoviesDB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComputedName)
                    .HasMaxLength(161)
                    .IsUnicode(false)
                    .HasComputedColumnSql("((([Name]+' (')+CONVERT([varchar],datepart(year,[ReleaseDate])))+')')");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GenreID");
            });
        }
    }
}
