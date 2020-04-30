using System;
using System.Collections.Generic;
using System.Text;

namespace Aula24
{
    internal class HashImp
    {
        public void SetHash()
        {
            //Aplicação de conjunto de dados. Implementando HashSet.

            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();

            setA.Add(3);
            setA.Add(5);
            setA.Add(8);
            setA.Add(9);

            setB.Add(3);
            setB.Add(4);
            setB.Add(5);

            foreach (int item in setA)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}