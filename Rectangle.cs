using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Rectangle : Geometry //Rectangle class which inherits from base class Geometry
    {
        public double lengthA { get; set; }
        public double lengthB { get; set; }
        public Rectangle() //Constructor
        {
            lengthA = 4;
            lengthB = 3;
        }
        override public double Area()//Method which override the base class method to count the area of the rectangle.
        {
            double area = lengthA * lengthB; 
            return area;
        }
    }
}
