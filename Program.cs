using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry cirkel = new Cirkel(); //Circle object
            Console.WriteLine("Arean of the circle: " + cirkel.Area() + "Cm");

            Geometry square = new Square();//Square object
            Console.WriteLine("Arean of the square: " + square.Area() + "Cm");

            Geometry rectangle = new Rectangle();//Rectangle object
            Console.WriteLine("Arean of the rectangle: " + rectangle.Area() + "Cm");
        }
    }
}
