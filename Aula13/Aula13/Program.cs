﻿using System;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar: ");

            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);

                int a = int.Parse(Console.ReadLine());
                soma += a;
            }

            Console.WriteLine(soma);
        }
    }
}
