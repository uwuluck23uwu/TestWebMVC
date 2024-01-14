using Microsoft.EntityFrameworkCore;
using MVC_Homework_1.Data;
using MVC_Homework_1.Models;

namespace MVC_Homework_1.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _db;

        public ProductService(DataContext _db)
        {
            this._db = _db;
        }

        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _db.Categories.OrderByDescending(p => p.Id).ToListAsync();
        }
        public async Task AddCategory(Category category)
        {
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
        }
        public async Task<Category> FindCategory(int id)
        {
            return await _db.Categories.FindAsync(id);
        }
        public async Task DeleteCategory(Category category)
        {
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateCategory(Category category)
        {
            _db.Categories.Update(category);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Component>> GetComponent()
        {
            return await _db.Components.Include(p => p.Feature).OrderByDescending(p => p.Id).ToListAsync();
        }
        public async Task AddComponent(Component component)
        {
            await _db.Components.AddAsync(component);
            await _db.SaveChangesAsync();
        }
        public async Task<Component> FindComponent(int id)
        {
            return await _db.Components.FindAsync(id);
        }
        public async Task DeleteComponent(Component component)
        {
            _db.Components.Remove(component);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateComponent(Component component)
        {
            _db.Components.Update(component);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Feature>> GetFeature()
        {
            return await _db.Features.OrderByDescending(p => p.Id).ToListAsync();
        }
        public async Task AddFeature(Feature feature)
        {
            await _db.Features.AddAsync(feature);
            await _db.SaveChangesAsync();
        }
        public async Task<Feature> FindFeature(int id)
        {
            return await _db.Features.FindAsync(id);
        }
        public async Task DeleteFeature(Feature feature)
        {
            _db.Features.Remove(feature);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateFeature(Feature feature)
        {
            _db.Features.Update(feature);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _db.Products.Include(p => p.Category).OrderByDescending(p => p.Id).ToListAsync();
        }
        public async Task AddProduct(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
        }
        public async Task<Product> FindProduct(int id)
        {
            return await _db.Products.FindAsync(id);
        }
        public async Task DeleteProduct(Product product)
        {
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateProduct(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductDetail>> GetDetail()
        {
            return await _db.ProductDetail.Include(p => p.Product).OrderByDescending(p => p.Id).ToListAsync();
        }
        public async Task AddDetail(ProductDetail detail)
        {
            await _db.ProductDetail.AddAsync(detail);
            await _db.SaveChangesAsync();
        }
        public async Task<ProductDetail> FindDetail(int id)
        {
            return await _db.ProductDetail.FindAsync(id);
        }
        public async Task DeleteDetail(ProductDetail detail)
        {
            _db.ProductDetail.Remove(detail);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateDetail(ProductDetail detail)
        {
            _db.ProductDetail.Update(detail);
            await _db.SaveChangesAsync();
        }
    }
}
