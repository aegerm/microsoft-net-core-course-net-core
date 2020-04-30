using System;
using System.Collections.Generic;
using System.Globalization;
using Aula41.Entities;
using Aula41.Entities.Enums;

namespace Aula41
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            System.Console.Write("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                System.Console.WriteLine($"Shape #{i} data:");
                
                System.Console.Write("Retangulo ou Circulo (r/c)?");
                char ch = char.Parse(Console.ReadLine());

                System.Console.Write("Cor [Azul-Preto-Vermelho]: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch.Equals('r'))
                {
                    System.Console.Write("Largura: ");
                    double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Altura: ");
                    double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(w, h, color));
                }

                else
                {
                    System.Console.WriteLine("Raio: ");
                    double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(r, color));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Área das Figuras:");

            foreach(Shape s in list)
            {
                System.Console.WriteLine("Área: " + s.Area());
                System.Console.WriteLine("Cor: " + s.Color);
            }
        }
    }
}
