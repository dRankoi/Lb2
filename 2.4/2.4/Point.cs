using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4
{
    class Point
    {
        public int I1 { get; }
        public int I2 { get; }
        public string S1 { get; }
        public Point( int integer1, int integer2, string string1="")
        {
            I1 = integer1;
            I2 = integer2;
            S1 = string1;
        }
    }
}
