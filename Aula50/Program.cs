using System;
using System.Collections.Generic;
using System.Linq;
using Aula50.Entities;

namespace Aula50
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            System.Console.WriteLine(message);

            foreach (T obj in collection)
            {
                System.Console.WriteLine(obj);
            }
        }

        static void Main(string[] args)
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Ferramentas";
            category.Tier = 2;

            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Computadores";
            category2.Tier = 1;

            Product product = new Product();
            product.Id = 1;
            product.Name = "Alicate";
            product.Price = 35.00;
            product.Category = category;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Chave de Fenda";
            product2.Price = 25.00;
            product2.Category = category;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "PC-Gamer Turbo";
            product3.Price = 3550.00;
            product3.Category = category2;

            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(product2);
            products.Add(product3);

            //var r1 = products.Where(p => p.Category.Tier == 1); //Buscar produto onde a categoria é tier 1.
            var r1 = from p in products where p.Category.Tier == 1 select p;
            Print("Tier 1: ", r1);

            System.Console.WriteLine();

            //var r2 = products.Where(p => p.Category.Name.Equals("Ferramentas")).Select(p => p.Name); //buscar produtos que são ferramentas.
            var r2 = from p in products where p.Category.Name == "Ferramentas" select p.Name;
            Print("Nome dos produtos que são ferramentas:", r2);

            System.Console.WriteLine();

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //objeto anonimo e com alias 'CategoryName'
            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Nomes iniciados em C e objeto anonimo:", r3);

            System.Console.WriteLine();

            //var r4 = products.Where(p => p.Category.Tier == 2).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print("Ordenação por Preço e Nome: ", r4);

            System.Console.WriteLine();

            var r5 = r4.Skip(1).Take(2);
            Print("", r5);

            System.Console.WriteLine();

            var r6 = products.Max(p => p.Price);
            System.Console.WriteLine(r6);

            System.Console.WriteLine();

            var r7 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x,y) => x + y);
            System.Console.WriteLine(r7);
        }
    }
}