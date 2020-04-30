using Aula41.Entities.Enums;

namespace Aula41.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}