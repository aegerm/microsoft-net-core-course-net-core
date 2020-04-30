using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 4.5f;

            float multiplex = 6.8f;

            float result = number * multiplex;

            Console.WriteLine(result);

            string name = "Alexandre Marques";

            Console.WriteLine(name);

            object obj = "Genérico para string";

            Console.WriteLine((string)obj);

            int validateMinNumber = int.MinValue;
            Console.WriteLine(validateMinNumber);

            int validateMaxNumber = int.MaxValue;
            Console.WriteLine(validateMaxNumber);

            int n1 = 50;
            int n2 = -50;

            if (n1 <= validateMaxNumber)
            {
                Console.WriteLine(n1);
            }

            if (n2 >= validateMinNumber)
            {
                Console.WriteLine(n2);
            }
        }
    }
}