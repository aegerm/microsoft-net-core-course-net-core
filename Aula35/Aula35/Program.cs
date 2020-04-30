using System;

namespace Aula35
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Upper Case
            string original = "alexandre marques";

            string converterMaiusculo = original.ToUpper();
            Console.WriteLine(converterMaiusculo);

            //To Lower Case
            string value = "AAAAAAA";

            string _toLowerCase = value.ToLower();
            Console.WriteLine(_toLowerCase);

            string _trim = "Meu nome com espaçamento" + " -";

            string format = _trim.Trim();
            Console.WriteLine(format);

            int index = original.IndexOf("le");
            Console.WriteLine(index);

            int last = original.LastIndexOf("le");
            Console.WriteLine(last);

            //Começa a string na posição 1
            string s4 = original.Substring(index);
            Console.WriteLine(s4);

            //Apresenta 5 caracteres a partir da posição 3
            string s5 = original.Substring(3, 5);
            Console.WriteLine(s5);

            string s6 = original.Replace('a', 'x');
            Console.WriteLine(s6);

            string s7 = original.Replace("ale", "vs");
            Console.WriteLine(s7);

            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine(b1);

            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);
        }
    }
}
