using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ProductContext db=new ProductContext())
            {
                Product product1 = new Product { ProductName = "milk", ProductId = 1 };
                db.Products.Add(product1);
                db.SaveChanges();
                Console.WriteLine("objects saved good");
                var products = db.Products;
                Console.WriteLine("Список объектов:");
                foreach (Product u in products)
                {
                    Console.WriteLine("{0},{1}", u.ProductId, u.ProductName);
                }
            }

        }
    }
 }