using OnlineMarketApp_Controllers;
using OnlineMarketApp_Helpers;
using OnlineMarketApp_Models;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            OnlineMarket market = new OnlineMarket("market");

            Controller.ShowMenu();

        repeat:
            int option;
            bool isOption = int.TryParse(Console.ReadLine(), out option);

            if (!isOption)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "enter betwen 0-9 numbers");
                goto repeat;
            }

            switch (option)
            {
                case 1:
                    Controller.ShowAllProducts(market);
                    goto repeat;

                case 2:
                    Controller.AddNewProduct(market);
                    goto repeat;

                case 3:
                    Controller.RemoveProduct(market);
                    goto repeat;

                case 4:
                    Controller.FindProductById(market);
                    goto repeat;

                case 5:
                    Controller.ShowCart(market);
                    goto repeat;

                case 6:
                    Controller.AddProductToCart(market);
                    goto repeat;

                case 7:
                    Controller.FindCartItemById(market);
                    goto repeat;

                case 8:
                    Controller.CheckCartItemExists(market);
                    goto repeat;

                case 9:
                    Controller.ClearConsole();
                    goto repeat;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Düzgün seçim edin.");
                    goto repeat;
            }
        }
    }
}
