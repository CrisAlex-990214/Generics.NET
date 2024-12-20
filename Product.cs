namespace Generics.NET
{
    public class Product: ICommonEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Order: ICommonEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public interface ICommonEntity 
    {
        public string Name { get; set; }
    }

    public class Body
    {
        public string Name { get; set; }
    }
}
