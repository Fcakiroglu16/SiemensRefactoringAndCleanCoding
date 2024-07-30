using System.Diagnostics.Eventing.Reader;
using Domain;
using Microsoft.Extensions.Caching.Memory;

namespace Application
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public void Add(ProductDto p)
        {
            //Console.WriteLine("Add Methodu çalıştı");


            var newProduct = new Product() { Id = p.Id, Name = p.Name };
            productRepository.Save(newProduct);
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll().ToList();
        }

        public decimal Calculate(string price)
        {
            var httpClient = new HttpClient();
            try
            {
                decimal newPrice = decimal.Parse(price);
                httpClient.GetAsync("https://www.google.com");
            }
            catch (Exception e)
            {
                throw;
            }

            return 0;
        }


        public void Delete(ProductDto p)
        {
            //Console.WriteLine("Delete Methodu çalıştı");
            var newProduct = new Product() { Id = p.Id, Name = p.Name };
            productRepository.Delete(newProduct);
        }
    }
}