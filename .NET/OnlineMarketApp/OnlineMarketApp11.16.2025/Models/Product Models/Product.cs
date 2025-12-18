using OnlineMarketApp_Common;

namespace OnlineMarketApp_Product_Models

{
    public class Product : BaseModel<Product>
    {
        public int Id { get; }
        public string Name;
        public int Stock;
        public double Price;

        public Product(string name, int stock, double price)
        {
            Id = GenrateId();
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
