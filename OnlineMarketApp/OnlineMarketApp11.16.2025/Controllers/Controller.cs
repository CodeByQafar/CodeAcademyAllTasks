using OnlineMarketApp_CardItem_Models;
using OnlineMarketApp_Exceptions;
using OnlineMarketApp_Helpers;
using OnlineMarketApp_Models;
using OnlineMarketApp_Product_Models;

namespace OnlineMarketApp_Controllers
{

    public static class Controller
    {
        public static void ClearConsole()
        {
            Console.Clear();
            ShowMenu();
        }
        public static void ShowMenu()
        {
            Console.WriteLine(
                "  select option\n" +
        " 1. Show all products \n" +
        " 2. Add new product\n" +
        " 3. Remove product\n" +
        " 4. Find product by ID\n" +
        " 5. Show cart\n" +
        " 6. Add product to cart\n" +
        " 7. Find cart item by ID\n" +
        " 8. Check if cart item exists\n" +
        " 9. Clear console\n" +
        " 0. Exit\n"
        ) ;  
        }

        public static void ShowAllProducts(OnlineMarket market)
        {
            market.ShowProducts();
        }

        public static void AddNewProduct(OnlineMarket market)
        {
            string Name;
            int Stock;
            double Price;

            Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product name:");
            Name = Console.ReadLine();


        Stock: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product stock:");
            bool isStockValid = int.TryParse(Console.ReadLine(), out Stock);
            if (!isStockValid)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid stock value. Please enter a valid integer.");
                goto Stock;
            }
        Price: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product price:");
            bool isPriceValid = double.TryParse(Console.ReadLine(), out Price);
            if (!isPriceValid)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid price value. Please enter a valid number.");
                goto Price;
            }
            Product newProduct = new Product(Name, Stock, Price);
            market.AddProduct(newProduct);
            Helpers.ConsoleWriteline(ConsoleColor.Green, "Product added successfully.");
        }

        public static void RemoveProduct(OnlineMarket market)
        {
            int id;
        id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product Id to remove:");
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                goto id;
            }
            try
            {
                market.RemoveProduct(id);
                Helpers.ConsoleWriteline(ConsoleColor.Green, "Product removed successfully");
            }
            catch (ProductNotFound ex)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, ex.Message);
            }
        }

        public static void FindProductById(OnlineMarket market)
        {
            int id;
        id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product Id to find:");
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                goto id;
            }
            try
            {
                Product product = market.FindProductById(id);
                Helpers.ConsoleWriteline(ConsoleColor.Green, $"Product finded name:{product.Name} stock:{product.Stock} price:{product.Price}");
            }
            catch (ProductNotFound ex)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, ex.Message);
            }
        }

        public static void ShowCart(OnlineMarket market)
        {
            market.ShowCart();
        }

        public static void AddProductToCart(OnlineMarket market)
        {
            try
            {
                int id;
                int Quantity;

            id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product Id to add to cart:");
                bool isId = int.TryParse(Console.ReadLine(), out id);
                if (!isId)
                {
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                    goto id;
                }
                if (market.Products.FindById(id) == null)
                {
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Product with given Id does not exist.");
                    goto id;
                }

            quantity: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product quantity:");
                bool isStockValid = int.TryParse(Console.ReadLine(), out Quantity);
                if (!isStockValid)
                {
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid quantity value. Please enter a valid integer.");
                    goto quantity;
                }

                market.AddToCart(id, Quantity);
                Helpers.ConsoleWriteline(ConsoleColor.Green, "Product added to cart successfully.");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ProductNotFound ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotEnoughProductException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static void FindCartItemById(OnlineMarket market)
        {
            try
            {
                int id;
            id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter cart item Id to find:");
                bool isId = int.TryParse(Console.ReadLine(), out id);
                if (!isId)
                {
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                    goto id;
                }
                if (!market.Cart.IsExists(id))
                {
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "cart item with given Id does not exist.");
                    goto id;
                }

                CartItem cartItem = market.FindCardItemById(id);
                Helpers.ConsoleWriteline(ConsoleColor.Green, $"Cart item finded name:{cartItem.Name} quantity:{cartItem.Quantity} price:{cartItem.Price}");
            }
            catch (CartItemNotFound ex)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, ex.Message);
            }
        }

        public static void CheckCartItemExists(OnlineMarket market)
        {

            int id;
        id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter cart item Id to find:");
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                goto id;
            }
            if (market.Cart.IsExists(id))
            {
                Helpers.ConsoleWriteline(ConsoleColor.Green, "Cart item is exists.");
            }
            else
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "cart item with given Id does not exist.");

            }

        }

    }

}

