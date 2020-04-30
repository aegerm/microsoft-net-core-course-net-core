using System;
using System.Collections.Generic;
using System.Text;

namespace Aula19
{
    public class Produto
    {
        public string Name { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double valor, int quantidade)
        {
            Name = name;
            Valor = valor;
            Quantidade = quantidade;
        }

        public Produto(string name, double valor)
        {
            Name = name;
            Valor = valor;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public double ValorTotalProduto()
        {
            double valorTotal = Quantidade * Valor;

            return valorTotal;
        }
    }
}
