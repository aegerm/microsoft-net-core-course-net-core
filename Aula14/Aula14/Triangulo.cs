using System;

namespace Aula14
{
    public class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalcularArea()
        {
            double p = (A + B + C) / 2;

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}