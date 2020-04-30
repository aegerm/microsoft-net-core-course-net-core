using System;
using System.Linq;

namespace Aula49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5 }; //datasource

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach (int x in result)
            {
                System.Console.WriteLine(x);
            }
        }
    }
}