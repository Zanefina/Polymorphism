using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Square : Geometry//Square class which inherits from base class Geometry
    {
        public double length { get; set; }
        public Square() //Constructor
        {
            length = 4;
        }
        override public double Area()//Method which override the base class method to count the area of the square.
        {
            double area = length * length;
            return area;
        }
    }
}
