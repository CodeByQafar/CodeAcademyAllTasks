using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassTask11._07._2025.Models
{
    abstract class Product
    {
        private static int id = 0;
        public int Id
        {
            get { return id; }

        }
        public string Name;
        public int Price;
        public int Count;
        protected int TotalInCome;
        public Product(string Name, int Price, int Count, int TotalInCome)
        {
            id++;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
            this.TotalInCome = TotalInCome;
        }

        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
