using Aula39.Entities;
using System;

namespace Aula39
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(1000, "Alexandre", 0.0);
            
            BusinessAccount bacc = new BusinessAccount(1001, "Maria", 0.0, 500.0);

            //UPCASTING - Conversão da Superclasse para Subclasse
            Account ac1 = bacc; 

            Account ac2 = new BusinessAccount(1001, "Maria", 0.0, 500.0);

            Account ac3 = new SavingsAccount();

            //DOWNCASTING - Conversão da Subclasse para Superclasse
            BusinessAccount ba1 = (BusinessAccount)ac2;
            
            ba1.Loan(100.0);

            BusinessAccount b2 = null;

            if (ac3 is BusinessAccount) //instanceof
            {
                b2 = (BusinessAccount)ac3;

                BusinessAccount b3 = ac3 as BusinessAccount; //converter usando 'as'
            }

            if (ac3 is SavingsAccount)
            {
                SavingsAccount s1 = (SavingsAccount)ac3;
            }
        }
    }
}