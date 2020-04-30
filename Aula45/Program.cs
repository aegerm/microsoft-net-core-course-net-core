using System;

namespace Aula45
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 3, 27, 11, 10, 55);
            System.Console.WriteLine(dt.ElapsedTime());

            string s1 = "Alexandre Eger Marques";
            System.Console.WriteLine(s1.Cut(10));
        }
    }
}
