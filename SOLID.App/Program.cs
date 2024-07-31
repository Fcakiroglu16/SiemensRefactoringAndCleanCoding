// See https://aka.ms/new-console-template for more information

using SOLID.App;

Console.WriteLine("Solid");

var productBl = new ProductBL(new ProductDAL(), new RedisCacheService());

var userType = 2;

var products = new List<Product>();
if (userType == 1)
{
    products = productBl.GetProductList();
}
else
{
    productBl.ChangeRepository(new ProductDALWithOracle());
    products = productBl.GetProductList();
}


foreach (var product in products)
{
    Console.WriteLine($"{product.Id} {product.Name} {product.Price}");
}