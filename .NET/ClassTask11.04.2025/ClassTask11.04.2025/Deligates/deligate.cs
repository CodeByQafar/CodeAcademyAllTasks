using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ClassTask11._04._2025.Deligates
{
    internal class Deligates

    {
      static  public Func<int, int, int> sum = (x, y) => x + y;
     static   public Action<int, String> result = (num, message) =>
         {

             if (num < 100)
             {
                 Console.WriteLine("Great result!");

             }
             else
             {
                 Console.WriteLine(message);

             }
         };
    }
}
