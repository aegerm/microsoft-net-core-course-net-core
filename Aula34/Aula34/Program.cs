using System;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(0, 1, 30);
            Console.WriteLine(timeSpan);

            TimeSpan sp = TimeSpan.FromDays(1.5);
            Console.WriteLine(sp);

            TimeSpan sp1 = TimeSpan.FromHours(1.5);
            Console.WriteLine(sp1);

            DateTime d = new DateTime(2020, 4, 19, 22, 42, 00);
            Console.WriteLine(d);
            Console.WriteLine(d.Date);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.Kind);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.TimeOfDay);
            Console.WriteLine(d.Year);

            Console.WriteLine();

            Console.WriteLine(d.ToLongDateString());

            DateTime d2 = d.AddHours(1); //Adicionar uma hora a mais
            Console.WriteLine(d2);

            DateTime geradoBoleto = DateTime.Now; //Gerado boleto no dia x;
            Console.WriteLine("Boleto gerado em: " + geradoBoleto);

            DateTime vencimento = geradoBoleto.AddDays(7); //Vencimento após 7 dias
            Console.WriteLine("Vencimento: " + vencimento);

            DateTime atual = new DateTime(2020, 4, 19);
            DateTime apos = new DateTime(2020, 4, 22);

            TimeSpan t = apos.Subtract(atual); //Data Futura - Data Atual

            Console.WriteLine(t);
        }
    }
}
