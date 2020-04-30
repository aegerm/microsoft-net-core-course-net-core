using System;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3];

            Console.WriteLine(matrix.Rank); //quantidade de linhas

            Console.WriteLine(matrix.GetLength(0));
        }
    }
}
