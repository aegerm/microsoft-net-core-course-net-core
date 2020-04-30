using System;
using System.Collections.Generic;
using System.Text;

namespace Aula20
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Valor { get; set; }

        public void AdicionarDeposito(double deposito)
        {
            Valor = deposito;
        }

        public void Saque(double saque)
        {
            Valor -= saque;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", " +
                   "Titular: " + Titular + ", " +
                   "Saldo: " + Valor;
        }
    }
}
