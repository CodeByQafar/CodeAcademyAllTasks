using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task1
{
    public class Phone : Product
    {
        public int SIMCount;
        public Phone(int no, string name, int price, int discountPercent, int SIMCount) : base(no, name, price, discountPercent)
        {
            this.SIMCount = SIMCount;
        }

    }
}
