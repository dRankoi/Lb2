using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Age = 18, Name = "John", Surname = "Baton" };

            Console.WriteLine($"Имя: {user.Name}, фамилия: {user.Surname}, возраст:{user.Age}. Дата заполнения анкеты: {user.creationDate}.");

            Console.ReadKey();
        }
    }
}
