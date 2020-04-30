using System;
using System.Collections.Generic;
using System.Text;

namespace Aula21
{
    class Calculadora
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
