using MVC_Homework_1.Models;

namespace MVC_Homework_1.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Category>> GetCategory();
        Task AddCategory(Category category);
        Task<Category> FindCategory(int id);
        Task DeleteCategory(Category category);
        Task UpdateCategory(Category category);
        
        Task<IEnumerable<Component>> GetComponent();
        Task AddComponent(Component component);
        Task<Component> FindComponent(int id);
        Task DeleteComponent(Component component);
        Task UpdateComponent(Component component);
        
        Task<IEnumerable<Feature>> GetFeature();
        Task AddFeature(Feature feature);
        Task<Feature> FindFeature(int id);
        Task DeleteFeature(Feature feature);
        Task UpdateFeature(Feature feature);
        
        Task<IEnumerable<Product>> GetProduct();
        Task AddProduct(Product product);

        Task<IEnumerable<ProductDetail>> GetDetail();
        Task<Product> FindProduct(int id);
        Task DeleteProduct(Product product);
        Task UpdateProduct(Product product);

        Task AddDetail(ProductDetail detail);
        Task<ProductDetail> FindDetail(int id);
        Task DeleteDetail(ProductDetail detail);
        Task UpdateDetail(ProductDetail detail);
    }
}
