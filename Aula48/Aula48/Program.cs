using Aula48.Models;
using Aula48.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula48
{
    //delegate double BinaryNumericOperation(double n1, double n2);
    //delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {

            //BinaryNumericOperation op = CalculateService.Sum;
            //BinaryNumericOperation op = CalculateService.ShowSum;
            //op.Invoke(a, b);

            List<Product> products = new List<Product>();

            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Smartphone", 1900.00));
            products.Add(new Product("Ssd", 250.00));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = products.Select(func).ToList();

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            products.ForEach(act);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}