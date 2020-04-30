using System;
using System.Collections.Generic;
using Aula48.Entities;

namespace Aula48
{
    public class CCompare
    {
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

        public void execute()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Notebook", 2450.00));
            products.Add(new Product("Smartphone", 1900.00));

            //products.Sort(CompareProducts); //Delegate, referência para função com type safety
            
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //Expressão lambda
            //products.Sort(comp);

            products.Sort( (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}