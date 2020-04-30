using System;
using System.Collections.Generic;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = new List<string>();

            //Adiciona dados no final da lista
            array.Add("Alexandre Eger Marques");
            array.Add("Marcos");
            array.Add("Jael");

            //Adiciona um valor em uma posição da lista, especificamente.
            array.Insert(2, "Dean");

            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Count List: " + array.Count);

            string s1 = array.Find(x => x[0] == 'A'); //Dado x tal que x na posição 0 seja A.
            string s2 = array.FindLast(x => x[0] == 'J');

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int pos1 = array.FindIndex(x => x[0] == 'A'); //Primeiro elemento que começa com A
            Console.WriteLine(pos1);

            int pos2 = array.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2); //Ultimo elemento que começa com A

            Console.WriteLine("------------------------------------");

            List<string> result = array.FindAll(x => x.Length == 4); //Filtra registros pelo tamanho

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------***-------------------");

            array.Remove("Dean");

            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("*********************************");

            array.RemoveAll(x => x[0] == 'M');

            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            //RemoveRange recebe 2 parametros, então se o método receber os parametros (2, 2), ele vai remover a partir da posição 2 dois elementos.
        }
    }
}
