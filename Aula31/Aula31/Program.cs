using System;

namespace Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan span = TimeSpan.MaxValue;
            Console.WriteLine(span);

            TimeSpan t = new TimeSpan(3, 3, 5, 7);
            Console.WriteLine(t.Days); //Pegar o dia

            //DateTimeKind
            DateTime d1 = new DateTime(2020, 4, 19, 23, 10, 00, DateTimeKind.Local);
            DateTime d2 = new DateTime(2020, 4, 19, 23, 10, 00, DateTimeKind.Utc);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //Padrão ISO 8601
            DateTime dd1 = DateTime.Parse("2020-04-19 23:17:00");
            DateTime iso = DateTime.Parse("2020-04-19T23:18:00z"); //Formato UTC

            Console.WriteLine(iso);
            Console.WriteLine(dd1.ToUniversalTime().ToString("")); //Deve se usar ToUniversalTime para usar o ToString e aplicar a formatação ISO 8601
        }
    }
}
