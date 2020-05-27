using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animals> Animals { get; set; }
    public AnimalShelterContext (DbContextOptions options) : base(options) { }
  }
}