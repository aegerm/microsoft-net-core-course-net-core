using System;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Notebook";
            string produto2 = "Mesa Escritório";

            double preco1 = 4500.00;
            double preco2 = 315.56;

            Console.WriteLine("Informe o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome} comprou {produto1} por {preco1:F2} e uma {produto2} por {preco2}");
        }
    }
}
