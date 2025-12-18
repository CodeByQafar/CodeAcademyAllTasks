using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_Helpers
{
    public static class Helper
    {
        public static void ConsolWriteLine(ConsoleColor consoleColor,string text)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
     
    }
}
