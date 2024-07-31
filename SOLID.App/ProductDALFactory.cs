using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App
{
    internal class ProductDALFactory
    {
        private ProductDAL? productDal;

        public IProductDAL CreateDAL()
        {
            if (productDal is null)
            {
                return new ProductDAL();
            }

            return productDal;
        }
    }
}