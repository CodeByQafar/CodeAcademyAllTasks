using OnlineMarketApp_CardItem_Models;
using OnlineMarketApp_Exceptions;
using OnlineMarketApp_Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketApp_Product_Models
{


    public interface IProductList<T> where T : Product
    {
        void Add(T item);
        void Remove(int id);
        T FindById(int id);
    }
    public class ProductList<T> : IProductList<T> where T : Product
    {
        public List<T> Products;
        public ProductList()
        {
            Products = new List<T>();
        }

        public void Add(T item)
        {
            Products.Add(item);
        }

        public void Remove(int id)
        {
            T? product = Products.Find(e => e.Id == id);
            if (product != null)
            {
                Products.Remove(product);
                return;
            }
            throw new ProductNotFound("Product not found");
        }
        public T FindById(int id)
        {
            T? product = Products.Find(e => e.Id == id);
            if (product != null)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Green, "Product removed successfully");
                return product;
            }
            throw new ProductNotFound("Product not found");
        }
    }
}
