using P01_MvcConcept.Settings;

namespace P01_MvcConcept.IService
{
    public class ProductService : IProductService
    {
        public List<Product> ProductList { get; set; }

        public ProductService() 
        {
            ProductList = new List<Product>();
        }
        public void GenerateProduct(int number = 10)
        {
            Random r = new Random();
            var numberOfName = NameOfProduct.ProductName.Count;
            for (int i = 0; i < number; i++)
            {
                ProductList.Add(new Product 
                {
                    Id = i + 1,
                    Name = NameOfProduct.ProductName[r.Next(numberOfName)],
                    Price = r.Next(1,11) * 100,
                    Amount = r.Next(100) + 1
                });
            }
        }

        public List<Product> GetProductAll()
        {
            return ProductList;
        }
    }
}
