using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.Refactoring
{
    // Anemic Model / Rich Domain Model
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }


        public void BusinessRuleOne(decimal price)
        {
            if (price > 5000)
            {
                throw new Exception("Price is too high");
            }
        }

        public void BusinessRUleTwo(int stock)
        {
            if (stock < 1)
            {
                throw new Exception("Stock is too low");
            }
        }

        private Order()
        {
        }

        public Order(OrderDto order)
        {
            BusinessRuleOne(order.Price);

            BusinessRUleTwo(order.Stock);

            Price = order.Price;
            Name = order.Name;
            Stock = order.Stock;

            // Save to database
        }

        public static Order Create(OrderDto orderDto)
        {
            return new Order(orderDto);
        }
    }

    public class OrderDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }

    public class OrderService
    {
        public OrderService(IOrdeRepsitory orderRepository, IMemoryCache memoryCache, IStockRepository stockRepository)
        {
        }

        public void Create(OrderDto order)
        {
            var newOrder2 = new Order(order);
            //

            //stockRepository.check(
            // Save to database
        }
    }


    public class AService
    {
        public void TaxCalculate()
        {
        }
    }

    public interface IStockRepository
    {
    }

    public interface IMemoryCache
    {
    }

    public interface IOrdeRepsitory

    {
    }
}