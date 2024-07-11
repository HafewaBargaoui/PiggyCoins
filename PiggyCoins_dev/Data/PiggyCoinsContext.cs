using Microsoft.EntityFrameworkCore;
using PiggyCoins_dev.Models;

namespace PiggyCoins_dev.Data
{
    public class PiggyCoinsContext : DbContext
    {
        public PiggyCoinsContext(DbContextOptions<PiggyCoinsContext> options) :
base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
