using System;
using Aula41.Entities.Enums;

namespace Aula41.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, Radius);
        }
    }
}