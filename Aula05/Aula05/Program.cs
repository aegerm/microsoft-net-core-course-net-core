using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 3 + 4 * 2;
            Console.WriteLine(value1);

            int value2 = (3 + 4) * 2;
            Console.WriteLine(value2);

            int value3 = 17 % 3;
            Console.WriteLine(value3);

            double value4 = 10.0 / 8.0;
            Console.WriteLine(value4);

            Console.WriteLine();

            double a = 1.0, b = 3.0, c = 4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
