
using OnlineMarketApp_CardItem_Models;
using OnlineMarketApp_Exceptions;
using OnlineMarketApp_Helpers;
using OnlineMarketApp_Common;
using OnlineMarketApp_Product_Models;


namespace OnlineMarketApp_Models
{
    public interface IOnlineMarket<T, U> where T : Product where U : CartItem
    {
        void ShowProducts();
        void AddProduct(T product);
        void RemoveProduct(int id);
        T FindProductById(int id);
        void ShowCart();
        void AddToCart(int productId, int count);
        bool CardItemIsExists(int id);
        U FindCardItemById(int id);
    }
    public class OnlineMarket : BaseModel<OnlineMarket>, IOnlineMarket<Product, CartItem>
    {
        public int Id;
        public string Name;
        public CartItemList<CartItem> Cart;
        public ProductList<Product> Products;

        public OnlineMarket(string name)
        {
            Id = GenrateId();
            Name = name;
            Cart = new CartItemList<CartItem>();
            Products = new ProductList<Product>();
        }

        public void ShowProducts()
        {
            foreach (Product product in Products.Products)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Cyan, $"id:{product.Id}, name:{product.Name}, price:{product.Price}, stock:{product.Stock}");
            }
            if(Products.Products.Count == 0)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Yellow, "No products available");
            }
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void ShowCart()
        {
            foreach (CartItem item in Cart.CartItem)
            {
                Helpers.ConsoleWriteline(ConsoleColor.DarkYellow, $"name:{item.Name}, quantity:{item.Quantity}, price:{item.Price}");
            }
            if (Cart.CartItem.Count == 0)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Yellow, "Cart is empty");
            }
        }
        public void AddToCart(int productId, int count)
        {

            if (count < 0 || productId < 0)
            {
                throw new NegativeNumberException("Count and id must be greater than zero");
            }

            Product product = Products.FindById(productId);
            CartItem cartItem = new CartItem(product.Name, count, product.Price);

            if (product.Stock == 0)
            {
                throw new OutOfStockException("Product is out of stock");
            }
            if (product.Stock < count)
            {
                throw new NotEnoughProductException("Not enough stock for the product");
            }

            Cart.Add(cartItem, count);
            Products.Products[Products.Products.IndexOf(product)].Stock -= count;



        }

        public void RemoveProduct(int id)
        {
            Products.Remove(id);
        }

        public Product FindProductById(int id)
        {
            return Products.FindById(id);
        }

        public bool CardItemIsExists(int id)
        {
            return Cart.IsExists(id);
        }

        public CartItem FindCardItemById(int id)
        {
            return Cart.FindById(id);
        }
    }
}
