using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double Side1, double Side2)
        {
            side1 = Side1;
            side2 = Side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimetreCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimetreCalculator(); } }
    }
}
