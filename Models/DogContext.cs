using Microsoft.EntityFrameworkCore;
// using dog.Models;

namespace dog.Models
{
  public class DogContext : DbContext
  {
    // base() calls the parent class' constructor passing the "options" parameter along
    public DogContext(DbContextOptions<DogContext> options) : base(options) { }

    public DbSet<User> users { get; set; }
    public DbSet<Activity> activities { get; set; }
    public DbSet<Part> part { get; set; }

  }
}


