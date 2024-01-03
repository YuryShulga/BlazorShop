using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Models
{
    public class AppDbContext : DbContext
    {
        //Список таблиц:
        public DbSet<Product> Products { get; set; }

        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }

}
