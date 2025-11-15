using OnlineMarketApp_Exceptions;
using OnlineMarketApp_Helpers;


namespace OnlineMarketApp_CardItem_Models
{
    public interface ICartItem<T> where T : CartItem
    {
        void Add(T cartItem, int count);
        bool IsExists(int id);
        T FindById(int id);
    }
    public class CartItemList<T> : ICartItem<T> where T : CartItem
    {
        public List<T> CartItem;
        public CartItemList()
        {
            CartItem = new List<T>();
        }

        public void Add(T cartItem, int count)
        {
            CartItem.Add(cartItem);
            Helpers.ConsoleWriteline(ConsoleColor.Green, "CartItem added successfully");
        }


        public bool IsExists(int id)
        {
            T? cartItem = CartItem.Find(e => e.Id == id);
            if (cartItem != null)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Green, "CartItem is finded");

                return true;
            }
            Helpers.ConsoleWriteline(ConsoleColor.Red, "CartItem is not found");

            return false;

        }
        public T FindById(int id)
        {
            T? cartItem = CartItem.Find(e => e.Id == id);
            if (cartItem != null)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Green, "CartItem is finded");
                return cartItem;
            }
            throw new CartItemNotFound("CartItem Not Found");
        }


    }

}
