namespace Subscribe
{
    class Program
    {
        public class MarketData
        {
            public decimal Price { get; set; }
            public void Update (decimal price)
            {
                Price = price;
            }
        }

        static void Main(string[] args)
        {
            // TODO - object interested in MarketData price changes can subscribe to an update event
        }
    }
}