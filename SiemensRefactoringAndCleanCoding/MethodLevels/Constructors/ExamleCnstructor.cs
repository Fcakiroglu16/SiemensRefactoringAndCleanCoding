using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.MethodLevels.Constructors
{
    public class ProductService
    {
        public void Method()
        {
            var stock = 20;

            var product = new Product(1, "kalem 1", 100);
            var product2 = Product.Create(1, "kalem 2", 200);
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        private Product()
        {
        }

        //public Product(int id, string name)
        //{
        //    Id = id;
        //    Name = name.ToLower();
        //}

        //public Product(int id, string name, decimal price) : this(id, name)
        //{
        //    Price = price;
        //}

        //static factory methods
        public static Product Create(int id, string name, decimal price)
        {
            //business rule


            return new Product(id, name, price);
        }
    }
}