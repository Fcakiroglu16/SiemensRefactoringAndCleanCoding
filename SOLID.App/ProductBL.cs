using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App
{
    internal class ProductBL
    {
        private IProductDAL _productDal;
        private ICacheService _cacheService;

        public ProductBL(IProductDAL productDal, ICacheService cacheService)
        {
            _productDal = productDal;
            _cacheService = cacheService;
        }

        public void ChangeRepository(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProductList()
        {
            var products = _productDal.GetProducts();


            foreach (var product in products)
            {
                product.Price = product.Price * 1.20m;
            }

            _cacheService.Add("products", products, 10);
            return products;
        }
    }
}