using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IProductRepository
    {
        void Save(Product product);

        Product? GetById(int id);
        IEnumerable<Product> GetAll();

        void Delete(Product product);
    }
}