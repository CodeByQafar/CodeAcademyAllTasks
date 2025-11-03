using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask10._31._2025.Models.task1
{
     class Basket<T> where T : Fruit

    {
      public  List<T> fruits = new List<T>();

        public void AddFruit(T fruit)
        {
            fruits.Add(fruit);
        }
    }
}
