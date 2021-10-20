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
    }
}