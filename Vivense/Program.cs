using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Vivense
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Random rnd = new Random(100);
            for (int i = 0; i < 5; i++)
            {
                Product pr = new Product();
                pr.Id = rnd.Next(1,10);
                pr.Name = rnd.Next().ToString()+"a";
                products.Add(pr);
            }

            List<Product> ciftProduct = new List<Product>();
            List<Product> tekProduct = new List<Product>();

            foreach (var item in products)
            {
                if (item.Id % 2 == 0)
                {
                    ciftProduct.Add(item);
                }
                else
                {
                    tekProduct.Add(item);
                }
            }

            foreach (var item in ciftProduct.OrderBy(x=>x.Id))
            {
                Console.WriteLine(item.Id);
            }
            foreach (var item in tekProduct.OrderBy(x => x.Id))
            {
                Console.WriteLine(item.Id);

            }

        }
    }
}
