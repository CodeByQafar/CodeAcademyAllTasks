

namespace OnlineMarketApp_Helpers
{
    static public class Helpers

    {
        static public void ConsoleWriteline(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
