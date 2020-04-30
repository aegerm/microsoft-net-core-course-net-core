using System;

namespace Aula30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < products.Length; i++)
            {
                string _name = Console.ReadLine();
                double _price = double.Parse(Console.ReadLine());

                products[i] = new Product(_name, _price);
            }

            double sum = 0.0;

            for (int i = 0; i < products.Length; i++)
            {
                sum += products[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine(avg.ToString("F2"));
        }
    }
}
