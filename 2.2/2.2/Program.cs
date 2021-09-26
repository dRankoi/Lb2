using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
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
