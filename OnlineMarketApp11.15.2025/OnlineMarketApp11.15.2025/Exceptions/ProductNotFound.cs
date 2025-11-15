using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketApp_Exceptions
{
    public class ProductNotFound:Exception
    {
        public ProductNotFound(string message):base(message)
        {
        }
    }
}
