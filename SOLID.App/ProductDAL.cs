namespace SOLID.App
{
    internal interface IProductDAL
    {
        List<Product> GetProducts();
    }


    internal class ProductDAL : IProductDAL
    {
        public List<Product> GetProducts()
        {
            return
            [
                new Product() { Id = 1, Name = "Kalem 1", Price = 100 },
                new Product() { Id = 2, Name = "Kalem 2", Price = 200 },
                new Product() { Id = 3, Name = "Kalem 3", Price = 300 }
            ];
        }
    }
}