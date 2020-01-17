using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class BestStylistsContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    public BestStylistsContext(DbContextOptions options) : base(options) { }
  }
}