using ClassTask11._07._2025.task_3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.task_3.Models
{
    class CurrencyConverter
    {
        public double Exchange(Currency currency, double azn)
        {
            double rate = 0;

            if (currency == Currency.USD)
            {
                rate = 0.59;
            }
            else if (currency == Currency.EUR)
            {
                rate = 0.55;
            }
            else if (currency == Currency.GBP)
            {
                rate = 0.47;
            }
            else if (currency == Currency.TRY)
            {
                rate = 5.50;
            }
            else
            {
              
                throw new ArgumentException("Düzgün Currency tipi göndərin.");
            }

            return azn * rate;
        }
    }
}
