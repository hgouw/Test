namespace Casting
{
    public class Asset
    {
        public string Name { get; set; }
    }

    public class House : Asset
    {
        public decimal Price { get; set; }
    }

    public class Stock : Asset
    {
        public long SharesOwned { get; set; }
    }
}