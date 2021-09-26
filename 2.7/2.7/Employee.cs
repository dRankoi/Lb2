using System;
using System.Collections.Generic;
using System.Text;

namespace _2._7
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void Calculator(out double salary, out double tax)
        {
            double baseSalary = 0d;

            switch (Post)
            {
                case "Junior":
                    baseSalary = 21000d;
                    break;
                case "Middle":
                    baseSalary = 45000d;
                    break;
                case "Senior":
                    baseSalary = 80000d;
                    break;
            }
            salary = baseSalary * Experience / 2d;
            tax = salary * 0.11d;
        }
    }
}
