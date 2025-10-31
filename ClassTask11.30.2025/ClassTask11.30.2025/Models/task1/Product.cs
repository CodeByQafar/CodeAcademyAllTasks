using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task1
{
    public class Product
    {

        public int no;
        public string name;
        public int price;
        public int discountPercent;
        public Product(int no, string name, int price, int discountPercent)
        {
            this.no = no;
            this.name = name;
            this.price = price;
            this.discountPercent = discountPercent;
        }
    }
}
