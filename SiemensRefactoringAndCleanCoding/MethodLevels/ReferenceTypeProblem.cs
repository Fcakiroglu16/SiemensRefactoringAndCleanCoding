namespace SiemensRefactoringAndCleanCoding.MethodLevels
{
    internal class ReferenceTypeProblem
    {
        public void Method1()
        {
            var product = new Product() { Id = 1, Name = "kalem 1", Price = 100 };


            Method2(product);
        }

        public void Method2(Product p)
        {
            var newProduct = p with { Price = p.Price * 1.20m };

            //  post send ( product)
        }
    }


    public record Product
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}