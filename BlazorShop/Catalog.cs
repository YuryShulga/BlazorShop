namespace BlazorShop
{
    public class Catalog
    {
        private readonly List<Product> products = new()
        {
            new Product{Id = 1, Name = "Clean Code" },
            new Product{Id = 2, Name = "Elegant objects" }
        };
        public IReadOnlyCollection<Product> GetProducts() { 
            return products;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
            
        }
    }
    public class Product 
    { 
        public int Id { get; set;}
        public string Name { get; set;}

        public decimal Price { get; set;}
    }
}
