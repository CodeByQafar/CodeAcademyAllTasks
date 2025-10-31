using ClassTask11._30._2025.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task1
{
    internal class Store
    {

        private Product[] products { get; set; }
        public Product[] Products { get; }
        public int NotebookLimit;
        public int PhoneLimit;
        public Store(Product[] products, int NotebookLimit, int PhoneLimit)
        {
            this.products = products;
            this.NotebookLimit = NotebookLimit;
            this.PhoneLimit = PhoneLimit;
        }
        public void AddProduct(Product product)
        {
            if (product is Notebook && noteBookCount() > NotebookLimit)
            {
                Console.WriteLine("You reached max NoteBook limit");
                return;
            }

            if (product is Phone && phoneCount() > PhoneLimit)
            {
                Console.WriteLine("tou reached max Phone limit");
                return;
            }
            Product[] res = new Product[products.Length + 1];
            for (int i = 0; i < products.Length; i++)
            {
                res[i] = products[i];
            }
            res[products.Length] = product;
            products = res;
        }

        public Product FindByNo(int no)
        {

            foreach (Product product in products)
            {
                if (product.no == no)
                {
                    return product;
                }
            }

            throw new productNotFound("product not found");
        }
        public int CalcNotebookAvg()
        {
            int count = 0;
            int total = 0;

            foreach (Product product in products)
            {
                if (product is Notebook)
                {
                    count++;
                    total += product.price;
                }

            }
            if (count > 0)
            {
                return total / count;

            }
            return 0;
        }

        public int noteBookCount()
        {
            int count = 0;

            foreach (Product product in products)
            {
                if (product is Notebook)
                {
                    count++;
                }
            }
            return count;
        }


        public int phoneCount()
        {
            int count = 0;

            foreach (Product product in products)
            {
                if (product is Phone)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
