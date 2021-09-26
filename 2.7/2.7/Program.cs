using System;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Baton")
            {
                Post = "Middle",
                Experience = 3
            };
            employee.Calculator(out double salary, out double tax);
            Console.WriteLine($"Имя: {employee.Name}\nФамилия: {employee.Surname}\nДолжность: {employee.Post}\nЗарплата: {salary}\nНалог: {tax} ");
            Console.ReadKey();
        }
    }
}
