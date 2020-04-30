﻿using Aula37.Entities.Enums;
using System.Collections.Generic;

namespace Aula37.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract hc in Contracts)
            {
                if (hc.Date.Year == year && hc.Date.Month == month)
                {
                    sum += hc.TotalValues();
                }
            }

            return sum;
        }
    }
}