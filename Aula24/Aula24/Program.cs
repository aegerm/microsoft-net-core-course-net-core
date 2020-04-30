using System;
using System.Collections.Generic;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();

            setA.Add(3);
            setA.Add(5);
            setA.Add(8);
            setA.Add(9);
            setA.Add(9);

            setB.Add(3);
            setB.Add(4);
            setB.Add(5);

            //setA.Remove(9);

            //setA.ExceptWith(setB);

            //setA.UnionWith(setB);

            //setA.IntersectWith(setB);

            foreach (int item in setA)
            {
                Console.WriteLine(item);
            }
        }
    }
}
