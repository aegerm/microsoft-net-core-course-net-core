using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Alexandre Marques";
            p1.Idade = 23;

            Pessoa p2 = new Pessoa();
            p2.Nome = "Alessandro Marques";
            p2.Idade = 19;

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha é {p1.Nome}");
            }

            else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine($"Pessoa mais velha é {p2.Nome}");
            }

            else
            {
                Console.WriteLine("Ambos com mesma idade");
            }
        }
    }
}