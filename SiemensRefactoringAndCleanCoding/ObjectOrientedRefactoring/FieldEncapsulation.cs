namespace SiemensRefactoringAndCleanCoding.ObjectOrientedRefactoring.FieldEncapsulation
{
    public class Product
    {
        public const int FromPriceValidation = 3000;
        public const int ToPriceValidation = 5000;


        public int Id { get; set; }


        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                if (value is > Product.FromPriceValidation and < Product.ToPriceValidation)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("hata");
                }
            }
        }

        public void SetPrice(decimal newPrice)
        {
            if (newPrice is > Product.FromPriceValidation and < Product.ToPriceValidation)
            {
                Price = newPrice;
            }
            else
            {
                throw new Exception("hata");
            }
        }


        public Product(int id, string name, decimal price)
        {
            SetPrice(price);
        }
    }


    public class ProductService
    {
        public void UpdateProductPrice(Product product, decimal newPrice)
        {
            product.Price = newPrice;
        }

        public void MakeToRequest(int a, string b, decimal c)
        {
        }
    }


    public record OrderDto
    {
        public int Id { get; init; }
    }
}