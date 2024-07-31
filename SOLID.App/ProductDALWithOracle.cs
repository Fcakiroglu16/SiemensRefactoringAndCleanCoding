using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App
{
    internal class ProductDALWithOracle : IProductDAL
    {
        public List<Product> GetProducts()
        {
            return
            [
                new Product() { Id = 1, Name = "Kalem 1(Oracle)", Price = 100 },
                new Product() { Id = 2, Name = "Kalem 2(Oracle)", Price = 200 },
                new Product() { Id = 3, Name = "Kalem 3(Oracle)", Price = 300 }
            ];
        }
    }
}