using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto
            {
                Name = "TV",
                Valor = 980.00,
                Quantidade = 5
            };

            Console.WriteLine(produto.Name);
        }
    }
}
