using System;
using System.Globalization;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "Informe o nome de usuário";
            Console.WriteLine(info);

            string name = Console.ReadLine(); //Entrada de valores
            Console.WriteLine("Nome do usuário: " + name);

            double value = 10.56325;

            Console.WriteLine("Seu saldo é: " + value.ToString("F2")); //Apresenta somente o valor com duas casas decimais depois da vírgula.

            Console.WriteLine("Saldo formatado: " + value.ToString("F2", CultureInfo.InvariantCulture)); //Apresenta o valor formatado com ponto.

            int age = 23;
            double saldo = 7.076;
            string lastName = "Marques";

            Console.WriteLine("{0} tem {1} anos e tem saldo de {2} reais", lastName, age, saldo); //Interpolação
            Console.WriteLine($"{lastName} tem {age} anos e tem saldo de {saldo:F4} reais"); //Placeholder
        }
    }
}
