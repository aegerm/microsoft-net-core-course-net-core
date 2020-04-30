using System;
using System.Globalization;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            //ticks é uma propriedade do .Net que representa 100 nano segundo

            DateTime time = DateTime.Now;

            DateTime date1 = new DateTime(2020, 4, 19);
            DateTime date2 = new DateTime(2020, 4, 19, 17, 50, 10);
            DateTime date3 = new DateTime(2020, 4, 19, 17, 51, 03, 500); //Não leva em consideração os milisegundos

            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;

            DateTime date_01 = DateTime.Parse("2020-04-19");
            DateTime date_02 = DateTime.Parse("2020-04-19 22:08:00");
            DateTime date_03 = DateTime.Parse("19/04/2020 22:10:00");

            DateTime dt01 = DateTime.ParseExact("2020-04-19", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dt02 = DateTime.ParseExact("19/04/2020 22:10:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(time);
            Console.WriteLine(time.Ticks);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine();
            Console.WriteLine(date_01);
            Console.WriteLine(date_02);
            Console.WriteLine(date_03);
            Console.WriteLine(dt01);
            Console.WriteLine(dt02);
        }
    }
}
