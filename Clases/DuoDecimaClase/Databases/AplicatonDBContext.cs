using DuoDecimaClase.Models;
using Microsoft.EntityFrameworkCore;

namespace DuoDecimaClase.Databases;
public class AplicatonDBContext:DbContext
{
    public DbSet<Coder> Coder {get; set;}
    public ApllicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
    {

    }
}
