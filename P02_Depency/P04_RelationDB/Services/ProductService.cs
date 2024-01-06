using Microsoft.EntityFrameworkCore;
using P04_RelationDB.Services;

namespace P04_RelationDB.Services
{
    public class ProductService : IProductService
    {
        public readonly DataContext dataContext;
        public readonly IWebHostEnvironment webHostEnvironment;

        public ProductService(DataContext dataContext, IWebHostEnvironment webHostEnvironment) 
        {
            this.dataContext = dataContext;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await dataContext.Products.ToListAsync();
            products.ForEach(product =>
            {
                product.ImageUrl = !string.IsNullOrEmpty(product.ImageUrl) ? Path.Combine(Paths.Images, product.ImageUrl) : "NoImage.jpg";
            });
            return products;
            //return dataContext.Products.OrderByDescending(p => p.Id).ToList();
        }

        public async Task Add(Product product, IFormFile file)
        {
            string wwwRootPath = webHostEnvironment.WebRootPath;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(file.FileName);
                var folders = Path.Combine(wwwRootPath, Paths.Images);
                var externalFile = Path.Combine(folders, fileName + extension);
                var fileInDatabase = fileName + extension;

                if (!Directory.Exists(folders))
                {
                    Directory.CreateDirectory(folders);
                }

                using (var filStreams = new FileStream(externalFile, FileMode.Create))
                {
                    file.CopyTo(filStreams);
                }

                product.ImageUrl = fileInDatabase;
            }
            await dataContext.Products.AddAsync(product);
            await dataContext.SaveChangesAsync();
        }
    }
}
