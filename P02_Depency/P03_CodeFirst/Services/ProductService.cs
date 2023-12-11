using P03_CodeFirst.Data;
using P03_CodeFirst.Models;

namespace P03_CodeFirst.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _db;
        List<Product> ProductList;
        public ProductService(DataContext _db) 
        {
            this._db = _db;
            ProductList = new List<Product>();;
            if (_db.Products.Count() == 0) GenerateProduct();
        }

        public void Delete(Product product)
        {
            _db.Products.Remove(product); // ลบใน memory
            _db.SaveChanges(); // ลบใน data
        }

        public void GenerateProduct(int number = 10)
        {
            Random r = new Random();
            for (int i = 0; i < number; i++)
            {
                ProductList.Add(new Product
                {
                    //Id มันจะอ้อโต้
                    //Id = i,
                    Name = "Somo" + i,
                    Price = r.Next(10,101),
                    Amount = r.Next(1,10)
                });
            }
            _db.Products.AddRange(ProductList); //  อยู่ใน Memmory
            _db.SaveChanges(); // อยู่ใน Harddisk
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Product GetById(int id)
        {
            var product = _db.Products.Find(id);
            return product;
        }
    }
}
