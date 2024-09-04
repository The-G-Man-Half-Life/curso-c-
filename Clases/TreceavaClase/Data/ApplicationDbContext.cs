using Microsoft.EntityFrameworkCore;
using TreceavaClase.Models;

namespace TreceavaClase.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Owner>(Owner =>
        // {
        //             Owner.ToTable("owners");
        // Owner.HasKey(p => p.Id);
        // Owner.Property(p => p.Id).ValueGeneratedOnAdd();
        // Owner.Property(p => p.Name).HasMaxLength(100).IsRequired();
        // Owner.Property(p => p.LastName).HasMaxLength(100).IsRequired();
        // Owner.Property(p => p.ProfilePhoto).HasMaxLength(100).IsRequired();
        // Owner.Property(p => p.Address).HasMaxLength(200).IsRequired();
        // Owner.Property(p => p.Phone).HasMaxLength(25).IsRequired();
        // Owner.Property(p => p.Address).HasMaxLength(255).IsRequired();
        // Owner.Ignore(p => p.HairColor);
        // });


        modelBuilder.Entity<Vehicle>(vehicle =>
        {
            vehicle.ToTable("vehicles");
            vehicle.HasKey(v => v.Id);
            vehicle.Property(v => v.Id).ValueGeneratedOnAdd();
            vehicle.Property(v => v.Brand).HasMaxLength(100).IsRequired();
            vehicle.Property(v => v.Model).HasMaxLength(50).IsRequired();
            vehicle.Property(v => v.OwnerId).IsRequired();
            vehicle.Property(v => v.Year).HasMaxLength(4).IsRequired();
            vehicle.Property(v => v.Color).HasMaxLength(50).IsRequired();
            vehicle.Property(v => v.VehicleType).HasMaxLength(50).IsRequired();
            vehicle.Property(v => v.ChasisNumber).HasMaxLength(25).IsRequired();

            vehicle.HasOne(v => v.Owner)
                .WithMany(p => p.Vehicles)
                .HasForeignKey(v => v.OwnerId);
        });
    }
}
