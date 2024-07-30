using Application;
using Domain;

namespace Data
{
    public class ProductRepository : IProductRepository
    {
        private static readonly List<Product> ProductList =
            [new Product() { Id = 1, Name = "kalem 1" }, new Product() { Id = 1, Name = "kalem 2" }];


        public void Delete(Product product)
        {
            ProductList.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductList;
        }

        public Product? GetById(int id)
        {
            return ProductList.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Product product)
        {
            ProductList.Add(product);
        }
    }
}