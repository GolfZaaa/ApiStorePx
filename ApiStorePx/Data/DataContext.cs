using ApiStorePx.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiStorePx.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Restock> Restocks { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

    }
}
