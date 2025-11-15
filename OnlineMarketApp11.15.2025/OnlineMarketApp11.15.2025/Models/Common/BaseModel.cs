using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketApp_Common
{
    //auto id yaratmaq ucun
    public abstract class BaseModel<T> where T : BaseModel<T>
    {
        public static int id = -1;
        public int GenrateId()
        {
            id++;
            return id++;
        }
    }
}
