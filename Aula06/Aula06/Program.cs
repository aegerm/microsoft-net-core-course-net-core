using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 10;

            Console.WriteLine(variable);
            Console.WriteLine(variable += 2);
            Console.WriteLine(variable -= 2);
            Console.WriteLine(variable *= 2);
            Console.WriteLine(variable /= 2);
            Console.WriteLine(variable %= 2);

            string alfa = "ABC";
            Console.WriteLine(alfa);

            alfa += "DEF";
            Console.WriteLine(alfa);

            int v = ++variable; //incrementa e atualiza a varíável v;
            Console.WriteLine(v);
        }
    }
}
