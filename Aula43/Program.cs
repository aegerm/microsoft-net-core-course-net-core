using System;
using Aula43.Entities;
using Aula43.Exceptions;

namespace Aula43
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime now = DateTime.Now;

                System.Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                System.Console.Write("Check-in Date: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                System.Console.Write("Check-out Date: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                if (checkin < now || checkout < now)
                {
                    throw new DomainException("Datas inválidas!");
                }

                Reservation reservation = new Reservation();
                reservation.RoomNumber = number;
                reservation.CheckIn = checkin;
                reservation.Checkout = checkout;

                System.Console.WriteLine(reservation);
            }

            catch (DomainException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
