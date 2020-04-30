using System;
using System.Collections.Generic;
using System.Text;

namespace Aula37.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public double TotalValues()
        {
            double resultValue = Hours * ValuePerHour;

            return resultValue;
        }
    }
}