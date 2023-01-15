using Artisanaux.services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace Artisanaux.services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
         
    }
}
