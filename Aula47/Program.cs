using System;
using System.Collections.Generic;
using System.IO;
using Aula47.Entities;

namespace Aula47
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee>();

                    while(!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));
                    }

                    employees.Sort();

                    foreach(Employee e in employees)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}