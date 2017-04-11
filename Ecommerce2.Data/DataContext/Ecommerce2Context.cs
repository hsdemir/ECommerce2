using Ecommerce2.Data.Model;
using System.Data.Entity;

namespace Ecommerce2.Data.DataContext
{
    public class Ecommerce2Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

}