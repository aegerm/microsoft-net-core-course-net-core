using System;
using System.Collections.Generic;
using Aula48.Entities;

namespace Aula48
{
    class Program
    {
        static int _globalValue = 3;

        static void Main(string[] args)
        {
            int[] v = new int[] { 3, 4, 5 };

            ChangeOddValues(v);

            Console.WriteLine(string.Join(" ", v));
        }

        static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += _globalValue;
                }
            }
        }
    }
}