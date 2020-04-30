using System;
using System.Globalization;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua residência?");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Último nome, idade e altura na mesma linha:");
            string[] enter = Console.ReadLine().Split(' ');

            string lastName = enter[0];
            int age = int.Parse(enter[1]);
            double height = double.Parse(enter[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Resultados:");
            Console.WriteLine($"Nome Completo: {name}");
            Console.WriteLine($"Numero de Quartos {count}");
            Console.WriteLine($"Preço Produto {value:F2}");
            Console.WriteLine($"Último Nome: {lastName}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"Altura: {height:F2}");
        }
    }
}
