using Aula37.Entities;
using Aula37.Entities.Enums;
using System;
using System.Globalization;

namespace Aula37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string department = Console.ReadLine();

            Console.WriteLine("Dados Funcionário:");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Nível (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salário: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department _department = new Department();
            
            _department.Name = department;

            Worker _worker = new Worker();
            
            _worker.Name = name;
            _worker.Level = level;
            _worker.Department = _department;
            _worker.BaseSalary = salary;

            Console.Write("Quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Entre {i} dados do contrato:");
                
                Console.Write("Data: ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Valor por hora: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract();

                contract.Date = dateTime;
                contract.ValuePerHour = valueHour;
                contract.Hours = hours;

                _worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Mês e ano para cálculo de ganho (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int .Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: " + _worker.Name);
            Console.WriteLine("Departamento: " + _worker.Department.Name);
            Console.WriteLine($"Ganhos no mês {monthAndYear}: " + _worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}