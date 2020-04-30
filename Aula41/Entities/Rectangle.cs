using Aula41.Entities.Enums;

namespace Aula41.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        
        public override double Area()
        {
            double operation = (Width * Height);

            return operation;
        }
    }
}