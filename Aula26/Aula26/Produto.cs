using System;
using System.Collections.Generic;
using System.Text;

namespace Aula26
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEstoque()
        {
            double valorTotal = Preco * Quantidade;

            return valorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$"
                + ValorTotalEstoque()
                + ", "
                + Quantidade;
        }
    }
}
