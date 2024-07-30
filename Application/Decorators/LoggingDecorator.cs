using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Decorators
{
    public class LoggingDecorator : IProductService
    {
        private readonly IProductService _productService;

        public LoggingDecorator(IProductService productService)
        {
            _productService = productService;
        }

        public void Add(ProductDto p)
        {
            Console.WriteLine("Add method çalıştı");
            _productService.Add(p);
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("GetAll method çalıştı");
            return _productService.GetAll();
        }

        public void Delete(ProductDto p)
        {
            Console.WriteLine("Delete method çalıştı");
            _productService.Delete(p);
        }
    }
}