using Microsoft.EntityFrameworkCore;
using TreceavaClase.Models;

namespace TreceavaClase.Data;
public class ApplicationDbContext: DbContext
{
    public DbSet<Owner> Owners {get; set;}
    public DbSet<Vehicle> Vehicles {get; set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
