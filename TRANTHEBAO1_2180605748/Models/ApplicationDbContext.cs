using Microsoft.EntityFrameworkCore;

namespace TRANTHEBAO1_2180605748.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
    }
}
