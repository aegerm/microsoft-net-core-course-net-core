using System;
using System.Globalization;
using Aula46.Entities;
using Aula46.Services;

namespace Aula46.Views
{
    public class RentalConsole
    {
        public void execute()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Sistema de Reservas";

            Console.WriteLine("Enter rental data");

            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental();
            carRental.Start = start;
            carRental.Finish = finish;
            carRental.Vechicle = new Vehicle(model);

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessVoice(carRental);

            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);

            Console.ReadKey();
        }
    }
}