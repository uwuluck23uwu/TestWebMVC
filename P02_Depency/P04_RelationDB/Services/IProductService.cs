namespace P04_RelationDB.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task Add(Product product, IFormFile file);
    }
}
