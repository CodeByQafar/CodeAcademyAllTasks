using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask10._31._2025.Models.task2
{
    internal class MainPrintFile<T> where T : IPrintable,new()

    {
        T file=new T();
        public MainPrintFile()
        {
            file.Print();
        }
    }
}
