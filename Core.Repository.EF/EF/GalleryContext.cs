using System;
using Core.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Core.Repository.EF
{
    public partial class GalleryContext : DbContext
    {
        public static IConfiguration Configuration { get; set; }
        public GalleryContext()
        {
        }

        public GalleryContext(DbContextOptions<GalleryContext> options)
            : base(options)
        {
            
        }



        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarColor> CarColor { get; set; }
        public virtual DbSet<CarManufacturer> CarManufacturer { get; set; }
        public virtual DbSet<CarType> CarType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<TravelLocation> TravelLocation { get; set; }
        public virtual DbSet<TravelPlan> TravelPlan { get; set; }
        public virtual DbSet<TravelPlanEmployee> TravelPlanEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("GalleryContext"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AppUser>(user =>
            {
                user
                .Property(p => p.Id)
                .HasColumnName("UserId");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasIndex(e => e.LicencePlate)
                    .HasName("UQ__Car__68942C506CC75807")
                    .IsUnique();

                entity.Property(e => e.LicencePlate)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.CarColor)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarColorId)
                    .HasConstraintName("FK_Car_CarColor");

                entity.HasOne(d => d.CarManufacturer)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarManufacturerId)
                    .HasConstraintName("FK_Car_CarManufacturer");

                entity.HasOne(d => d.CarType)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarTypeId)
                    .HasConstraintName("FK_Car_CarType");
            });

            modelBuilder.Entity<CarColor>(entity =>
            {
                entity.HasIndex(e => e.Color)
                    .HasName("UQ__CarColor__E11D3845EAE41929")
                    .IsUnique();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CarManufacturer>(entity =>
            {
                entity.HasIndex(e => e.CompanyName)
                    .HasName("UQ__CarManuf__9BCE05DC50B857D1")
                    .IsUnique();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CarType>(entity =>
            {
                entity.HasIndex(e => e.TypeOfCar)
                    .HasName("UQ__CarType__B08431EA0369150B")
                    .IsUnique();

                entity.Property(e => e.TypeOfCar)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(150);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            

            modelBuilder.Entity<TravelLocation>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.Street).HasMaxLength(150);
            });

            modelBuilder.Entity<TravelPlan>(entity =>
            {
                entity.Property(e => e.ChangeDate).HasColumnType("datetime");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TravelPlan)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelPlan_Car");

                entity.HasOne(d => d.EndLocation)
                    .WithMany(p => p.TravelPlanEndLocation)
                    .HasForeignKey(d => d.EndLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelPlan_EndLocation");

                entity.HasOne(d => d.StartLocation)
                    .WithMany(p => p.TravelPlanStartLocation)
                    .HasForeignKey(d => d.StartLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelPlan_StartLocation");
            });

            modelBuilder.Entity<TravelPlanEmployee>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TravelPlanEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_TravelPlanEmployee_Employee");

                entity.HasOne(d => d.TravelPlan)
                    .WithMany(p => p.TravelPlanEmployee)
                    .HasForeignKey(d => d.TravelPlanId)
                    .HasConstraintName("FK_TravelPlanEmployee_TravelPlan");
            });
        }
    }
}
