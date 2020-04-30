using System;

namespace Aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                System.Console.WriteLine(result);
            }

            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }

            catch(FormatException e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}