using System;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Calculadora.Triple(ref a);

            Console.WriteLine(a);

            int b = 20;
            int t;

            Calculadora.Triple(b, out t);

            Console.WriteLine(t);
        }
    }
}
