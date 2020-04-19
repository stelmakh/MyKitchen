using MyKitchen.Models;
using Microsoft.EntityFrameworkCore;
namespace MyKitchen.Data
{
    public class MyKitchenContext : DbContext
    {
        public MyKitchenContext(DbContextOptions<MyKitchenContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
