using System;

namespace Aula43.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room "        + RoomNumber + 
                   ", Check-in "  + CheckIn.ToString("dd/MM/yyyy") + 
                   ", Check-out " + Checkout.ToString("dd/MM/yyyy") + 
                   ", Durations " + Duration();
        }
    }
}