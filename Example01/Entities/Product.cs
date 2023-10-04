
using Microsoft.EntityFrameworkCore;

namespace Example01.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        //public ProductDbContext() { }
        //public ProductDbContext(DbContextOptions<ProductDbContext>() : base()
        //{
        //    var options = new ;
        //    options.
        //}

    public ProductDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ALPEREN\\ALPERENMSSQL; database=ProductDb; Integrated Security=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products { get; set;}
    }
}
