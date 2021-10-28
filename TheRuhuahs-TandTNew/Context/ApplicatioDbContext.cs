using System;
using Microsoft.EntityFrameworkCore;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Booking> Bookings { get; set;}
        public DbSet<Package> Packages { get; set;}
        public DbSet<Payment> Payments { get; set;}
        public DbSet<TouristCenter> TouristCenters { get; set;}
        public DbSet<Trip> Trips { get; set;}
        public DbSet<UserRole> UserRoles { get; set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
            modelBuilder.Entity<Role>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Booking>().HasKey(s => s.Id);
            modelBuilder.Entity<Package>().HasKey(s => s.Id);
            modelBuilder.Entity<Payment>().HasKey(s => s.Id);
            modelBuilder.Entity<TouristCenter>().HasKey(s => s.Id);
            modelBuilder.Entity<Trip>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().Property(u => u.Email)
                .IsRequired();
            modelBuilder.Entity<UserRole>().HasKey(ur => ur.Id);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles).WithOne(ur => ur.User).HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles).WithOne(ur => ur.Role).HasForeignKey(ur => ur.RoleId);
            modelBuilder.Entity<UserRole>().HasIndex(U => U.UserId);
            modelBuilder.Entity<UserRole>().HasIndex(u => u.RoleId);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<User>().HasData(
                  new User
                  {
                      Id = 1,
                      RoleId = 1,
                      FirstName = "Oyediran",
                      LastName = "Umar",
                      Gender = "Male",
                      Email = "oyeleyeoyediran20@gmail.com",
                      DateOfBirth = DateTime.Now,
                      Mobile = "09026315926",
                      StreetAddress = "Asero",
                      State = "Abeokuta",
                      Country = "Nigeria",
                      Password = "1234",
                      PasswordHash = "lnjgV8+UnY+JzL+MW8HB2DGTbR/lSmCaAXfW0/sUUX4=",
                      HashSalt = "Rr+VsQuizJUuw6IIDqFEng=="
                  }
                    );
                  modelBuilder.Entity<User>().HasData(
                  new User
                  {
                      Id = 2,
                      RoleId = 2,
                      FirstName = "Ajibola",
                      LastName = "Umar",
                      Gender = "Male",
                      Email = "umaroyediran20@gmail.com",
                      DateOfBirth = DateTime.Now,
                      Mobile = "09026315926",
                      StreetAddress = "Asero",
                      State = "Abeokuta",
                      Country = "Nigeria",
                      Password = "12345",
                      PasswordHash = "GW5/aRGQzvZKdWVGizIQb6ZzeiRBREcaT2Etlm3af+Y=",
                      HashSalt = "HpW+UDBZdxj9aU/qKevVjQ=="
                  }
                );
            modelBuilder.Entity<Role>().HasData(
             new Role { Id = 1, RoleName = "SuperAdmin", CreatedAt = DateTime.Now }, new Role { Id = 2, RoleName = "Admin", CreatedAt = DateTime.Now }, new Role { Id = 3, RoleName = "Customer", CreatedAt = DateTime.Now }
            );
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, UserId = 1, RoleId = 1, CreatedAt = DateTime.Now });
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 2, UserId = 2, RoleId = 2, CreatedAt = DateTime.Now });

            base.OnModelCreating(modelBuilder);
        } 
    }
}