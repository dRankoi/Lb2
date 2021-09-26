using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(9, 7);

            Point point2 = new Point(6, 8);

            Point point3 = new Point(4, 5);

            Point point4 = new Point(2, 3);



            Figure figure = new Figure(point1, point2, point3, point4);

            figure.PerimeterCalculator();
        }
    }
}
