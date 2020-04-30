using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três numeros:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            InformaMaiorNumero(n1, n2, n3);
        }

        private static void InformaMaiorNumero(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Maior número é: {n1}");
            }

            else if (n2 > n3)
            {
                Console.WriteLine($"Maior número é: {n2}");
            }

            else
            {
                Console.WriteLine($"Maior número é: {n3}");
            }
        }
    }
}
