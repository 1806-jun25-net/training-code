using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project1.ContextLibrary
{
    public partial class Project1Context : DbContext
    {
        public Project1Context()
        {
        }

        public Project1Context(DbContextOptions<Project1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<LocationInventory> LocationInventory { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrder { get; set; }
        public virtual DbSet<PizzaOrderToppings> PizzaOrderToppings { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LocationInventory>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationName).HasMaxLength(20);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.Property(e => e.PizzaCrust).HasMaxLength(20);

                entity.Property(e => e.PizzaSize).HasMaxLength(10);
            });

            modelBuilder.Entity<PizzaOrder>(entity =>
            {
                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_PizzaOrder");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_PizzaOrder");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK3_PizzaOrder");
            });

            modelBuilder.Entity<PizzaOrderToppings>(entity =>
            {
                entity.HasKey(e => new { e.PizzaOrderId, e.ToppingName });

                entity.Property(e => e.ToppingName).HasMaxLength(20);

                entity.HasOne(d => d.PizzaOrder)
                    .WithMany(p => p.PizzaOrderToppings)
                    .HasForeignKey(d => d.PizzaOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_PizzaOrderToppings");

                entity.HasOne(d => d.ToppingNameNavigation)
                    .WithMany(p => p.PizzaOrderToppings)
                    .HasForeignKey(d => d.ToppingName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_PizzaOrderToppings");
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasKey(e => e.ToppingName);

                entity.Property(e => e.ToppingName)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();
            });
        }
    }
}
