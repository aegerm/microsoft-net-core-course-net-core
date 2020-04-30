using System;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");

            trianguloX.A = double.Parse(Console.ReadLine());
            trianguloX.B = double.Parse(Console.ReadLine());
            trianguloX.C = double.Parse(Console.ReadLine());

            Triangulo trianguloY = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            trianguloY.A = double.Parse(Console.ReadLine());
            trianguloY.B = double.Parse(Console.ReadLine());
            trianguloY.C = double.Parse(Console.ReadLine());

            double areaX = trianguloX.CalcularArea();
            double areaY = trianguloY.CalcularArea();

            Console.WriteLine("Área Triângulo X: {0}", areaX.ToString("F2"));
            Console.WriteLine("Área Triângulo Y: {0}", areaY.ToString("F2"));
        }
    }
}
