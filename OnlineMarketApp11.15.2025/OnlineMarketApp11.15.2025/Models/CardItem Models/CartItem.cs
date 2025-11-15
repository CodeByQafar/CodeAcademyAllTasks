using OnlineMarketApp_Common;

namespace OnlineMarketApp_CardItem_Models
{

 
    public class CartItem : BaseModel<CartItem>
    {
        public int Id;
        public string Name;
        public int Quantity;
        public double Price;
        public CartItem(string name, int quantity, double price)
        {
            Id = GenrateId();
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
