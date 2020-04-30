using System;
using System.Globalization;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //converter entrada de dados para receber valores inteiros
            Console.WriteLine(number);

            char ch = char.Parse(Console.ReadLine()); //converter entrada de dados para receber valores do tipo char
            Console.WriteLine(ch);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //converter entrada de dados para receber valores do tipo double
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
