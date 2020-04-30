using System;
using System.Collections.Generic;
using System.Text;

namespace Aula24
{
    class Matriz
    {
        public void InitMatriz()
        {
            //Desenvolvimento de matriz parâmetrizavel.

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }

            Console.WriteLine();

            int aux = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        aux++;
                    }
                }
            }

            Console.WriteLine(aux);
        }
    }
}
