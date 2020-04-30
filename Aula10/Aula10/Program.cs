using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Program p = new Program();

            p.defineNumeroPar(numbers);
            p.defineNumeroImpar(numbers);
        }

        private void defineNumeroPar(int[] vet)
        {
            Console.WriteLine("Pares: ");

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }

        private void defineNumeroImpar(int[] vet)
        {
            Console.WriteLine("Impares: ");

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 != 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
