using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._04._2025.Models
{
    internal class TemperatureSensor
    {
        static public Action<int> tempurator = (temp) =>
        {
            if (temp > 30)
            {
                Console.WriteLine("Warning: Too Hot!");
            }
            else
            {
                Console.WriteLine("Normal");

            }
        };
    }
}
