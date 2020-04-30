using System;
using System.Globalization;

namespace Aula47.Entities
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csv)
        {
            string[] vet = csv.Split(',');

            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (! (obj is Employee))
            {
                throw new ArgumentException("Object is not Employee");
            }

            Employee e = obj as Employee;

            return Name.CompareTo(e.Name);
        }
    }
}