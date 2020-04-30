using System;

namespace Aula46.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vechicle { get; set; }
        public Invoice Invoice { get; set; }
    }
}