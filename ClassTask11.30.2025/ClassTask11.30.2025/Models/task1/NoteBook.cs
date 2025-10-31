using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task1
{
    public class Notebook : Product
    {

        public int ram;
        public int storage;
        public Notebook(int no, string name, int price, int discountPercent, int ram, int storage) : base(no, name, price, discountPercent)
        {
            this.ram = ram;
            this.storage = storage;
        }
    }
}
