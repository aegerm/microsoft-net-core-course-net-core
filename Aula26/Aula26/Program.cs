using System;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Cadastrar Produtos ####");

            Produto p = new Produto();

            Console.WriteLine("Nome Produto:");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço Produto:");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine("Digite a quantidade a ser adicionado ao estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(quantidade);

            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine("Digite o numero de produtos a ser removidos:");
            int remover = int.Parse(Console.ReadLine());

            p.RemoverProdutos(remover);

            Console.WriteLine($"Dados do Produto: {p}");
        }
    }
}
