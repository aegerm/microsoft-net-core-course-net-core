using System;

namespace Aula33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso do tipo var
            var x = 10;
            var value = "Minha String";

            var error = value; //Quero receber um int, porém mandei uma string, debito técnico.

            Console.WriteLine(x);
            Console.WriteLine(value);

            //Usabilidade do switch case

            int received = int.Parse(Console.ReadLine());

            string day = "";

            switch (received)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "segunda";
                    break;
                default:
                    day = "n/d";
                    break;
            }

            Console.WriteLine(day);

            //Condição ternária

            double preco = 50.63;

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
