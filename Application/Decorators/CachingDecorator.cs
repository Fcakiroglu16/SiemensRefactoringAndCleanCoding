using Domain;
using Microsoft.Extensions.Caching.Memory;

namespace Application.Decorators
{
    public class CachingDecorator(IProductService productService, IMemoryCache memoryCache) : IProductService
    {
        public void Add(ProductDto p)
        {
            productService.Add(p);
        }

        public List<Product> GetAll()
        {
            if (memoryCache.TryGetValue("productList", out List<Product>? productList))
            {
                return productList!;
            }

            var products = productService.GetAll();
            memoryCache.Set<List<Product>>("productList", products);

            return products;
        }

        public void Delete(ProductDto p)
        {
            productService.Delete(p);
        }
    }
}