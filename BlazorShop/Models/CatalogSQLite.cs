
namespace BlazorShop.Models
{
    public class CatalogSQLite : ICatalog
    {
        private DbContextSQLite _context;

        public CatalogSQLite(DbContextSQLite context) 
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IReadOnlyCollection<Product> GetProducts()
        {
            
            return _context.Products.ToList();
        }
    }
}
