using System;

namespace Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 20;
            p.Y = 10;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

            double? x = null;
            Console.WriteLine(x.GetValueOrDefault());

            double? y = 50;
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine(y.Value);

            double? value = null;

            double? value2 = 10;

            double a = value ?? 5;
            double b = value2 ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
