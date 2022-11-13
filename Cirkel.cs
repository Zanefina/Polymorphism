using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Cirkel : Geometry //Circle class which inherits from base class Geometry
    {
        public double radius { get; set; } 
        public Cirkel() //Constructor 
        {
            radius = 4;
        }
        override public double Area() //Method which override the base class method to count the area of the circle.
        {
            double area = radius * radius * 3.141;
            return area;
        }
    }
}
