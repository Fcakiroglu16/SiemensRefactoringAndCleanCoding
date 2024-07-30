namespace Domain
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class Product
    {
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}