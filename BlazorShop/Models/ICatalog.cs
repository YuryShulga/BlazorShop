namespace BlazorShop.Models
{
	public interface ICatalog
	{
		public IReadOnlyCollection<Product> GetProducts();
		public void AddProduct(Product product);
	}
}