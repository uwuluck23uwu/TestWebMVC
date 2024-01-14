using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using P05_UploadFile.Settings;

namespace P05_UploadFile.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext dataContext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductService(DataContext dataContext, IWebHostEnvironment webHostEnvironment) 
        {
            this.dataContext = dataContext;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task Add(Product product, IFormFile file)
        {
            string wwwRootPath = webHostEnvironment.WebRootPath;
            if (file != null)
            {
                //string fileName = Guid.NewGuid().ToString() + DateTime.Now.ToString(); ใส่วันที่
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(file.FileName); // .jpg .png
                var folders = Path.Combine(wwwRootPath,Paths.Images);
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

        public async Task Delete(Product product)
        {

            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                var fileDelete = Path.Combine(webHostEnvironment.WebRootPath, Paths.Images, product.ImageUrl);
                if (File.Exists(fileDelete))
                {
                    File.Delete(fileDelete);
                }
            }

            dataContext.Products.Remove(product);
            await dataContext.SaveChangesAsync();
        }

        public async Task<Product> Find(int id)
        {
            var product = await dataContext.Products.FindAsync(id);
            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                product.ImageUrl = Path.Combine("\\", Paths.Images, product.ImageUrl);
            }
            return await dataContext.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            //return await dataContext.Products.ToListAsync();
            var products = await dataContext.Products.ToListAsync();
            products.ForEach(product =>
            {
                product.ImageUrl = !string.IsNullOrEmpty(product.ImageUrl)? Path.Combine(Paths.Images, product.ImageUrl): "NoImage.jpg";
            });
            return products;
        }

        public async Task Update(Product product, IFormFile file)
        {
            string wwwRootPath = webHostEnvironment.WebRootPath;
            if (file != null)
            {
                //string fileName = Guid.NewGuid().ToString() + DateTime.Now.ToString(); ใส่วันที่
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(file.FileName); // .jpg .png
                var folders = Path.Combine(wwwRootPath, Paths.Images);
                var externalFile = Path.Combine(folders, fileName + extension);
                var fileInDatabase = fileName + extension;

                if (!Directory.Exists(folders))
                {
                    Directory.CreateDirectory(folders);
                }
                //สร้างไฟล์ใหม่
                using (var filStreams = new FileStream(externalFile, FileMode.Create))
                {
                    file.CopyTo(filStreams);
                }
                //ลบไฟล์เดิม
                if (!string.IsNullOrEmpty(product.ImageUrl))
                {
                    var fileDelete = webHostEnvironment.WebRootPath+product.ImageUrl;
                    if (File.Exists(fileDelete))
                    {   
                        File.Delete(fileDelete);
                    }
                }

                product.ImageUrl = fileInDatabase;
            }

            dataContext.Products.Update(product);
            await dataContext.SaveChangesAsync();
        }
    }
}
