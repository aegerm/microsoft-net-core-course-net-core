using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.Write("Entre com o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (S/N)? ");
            string c = Console.ReadLine().ToLower();

            if (c.Equals("N"))
            {
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }

            else
            {
                Console.Write("Entre com um valor para depósito: ");
                conta.Valor = double.Parse(Console.ReadLine());

                conta.AdicionarDeposito(conta.Valor);

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);

                Console.Write("Deseja realizar um saque (S/N)? ");
                string s = Console.ReadLine().ToLower();

                if (s.Equals("S"))
                {
                    conta.Saque(conta.Valor);

                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(conta);
                }
            }
        }
    }
}
