using System;
using Aula40.Entities;

namespace Aula40
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Eger", 650.00);
            Account a2 = new SavingsAccount(102, "Marques", 650.00, 0.01);

            a1.WithDraw(20.00);
            a2.WithDraw(20.00);

            System.Console.WriteLine(a1.Balance);
            System.Console.WriteLine(a2.Balance);
        }
    }
}
