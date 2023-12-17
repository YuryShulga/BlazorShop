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
    }
    public class Product 
    { 
        public int Id { get; set;}
        public string Name { get; set;}

        public decimal Price { get; set;}
    }
}
