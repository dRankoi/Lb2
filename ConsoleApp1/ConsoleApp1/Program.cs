using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adress adress1 = new Adress() { index = 09102, country = "Poland", city = "Krakov", street = "Pinush", house = 2, apartment = 63 };

            //Console.WriteLine($"{adress1.index}, {adress1.country}, {adress1.city}, {adress1.street}, {adress1.house}, {adress1.apartment}");

            double s1, s2;



            Console.WriteLine("Введите значение первой стороны: ");

            s1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Введите значение второй стороны: ");

            s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(s1, s2);

            Console.WriteLine($"Площадь: {rectangle.Area}, периметр: {rectangle.Perimeter} ");

        }
    }
}
