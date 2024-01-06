using MVC_Homework_1.Models;

namespace MVC_Homework_1.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Category>> GetCategory();
        Task<IEnumerable<Component>> GetComponent();
        Task<IEnumerable<Feature>> GetFeature();
        Task<IEnumerable<Product>> GetProduct();
        Task<IEnumerable<ProductDetail>> GetDetail();

        Task AddCategory(Category category);
        Task AddComponent(Component component);
        Task AddFeature(Feature feature);
        Task AddProduct(Product product);
        Task AddDetail(ProductDetail detail);

        Task<Category> FindCategory(int id);
        Task<Component> FindComponent(int id);
        Task<Feature> FindFeature(int id);
        Task<Product> FindProduct(int id);
        Task<ProductDetail> FindDetail(int id);

        Task DeleteCategory(Category category);
        Task DeleteComponent(Component component);
        Task DeleteFeature(Feature feature);
        Task DeleteProduct(Product product);
        Task DeleteDetail(ProductDetail detail);

        Task UpdateCategory(Category category);
        Task UpdateComponent(Component component);
        Task UpdateFeature(Feature feature);
        Task UpdateProduct(Product product);
        Task UpdateDetail(ProductDetail detail);
    }
}
