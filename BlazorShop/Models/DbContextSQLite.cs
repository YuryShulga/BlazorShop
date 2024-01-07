using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Models
{
    public class DbContextSQLite : DbContext
    {
        //Список таблиц:
        public DbSet<Product> Products { get; set; }

        public DbContextSQLite(
            DbContextOptions<DbContextSQLite> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

}
