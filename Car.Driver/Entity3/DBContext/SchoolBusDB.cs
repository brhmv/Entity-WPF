using Entity3.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity3.DBContext
{
    internal class SchoolBusDB : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Ride> Rides { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ALLAHVERDI;Initial Catalog=SchoolBusDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ride>()
                .HasOne(r => r.Driver)
                .WithMany(d => d.Rides)
                .HasForeignKey(r => r.DriverId);

            modelBuilder.Entity<Ride>()
                .HasOne(r => r.Car)
                .WithOne()
                .HasForeignKey<Ride>(r => r.CarId);

            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Car)
                .WithOne(c => c.Driver)
                .HasForeignKey<Driver>(d => d.CarId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Car>()
                .HasKey(c => c.Id);
        }
    }
}