using System;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");

            double xA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            double yA = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2;

            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;

            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área Triângulo X: {0}", areaX.ToString("F2"));
            Console.WriteLine("Área Triângulo Y: {0}", areaY.ToString("F2"));
        }
    }
}
