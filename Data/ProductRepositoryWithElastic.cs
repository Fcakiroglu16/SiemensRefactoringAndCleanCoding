using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Data
{
    public class ProductRepositoryWithElastic : IProductRepository
    {
        public void Save(Product product)
        {
            Console.WriteLine(product.ToString());
            Console.WriteLine("Elastic kaydedildi");
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}