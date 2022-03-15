using System;
using BasisOOP.Classes;

namespace BasisOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Square square = new Square(12, 5);
            double area = square.Area();
            Console.WriteLine("Width: " + square.width);
            Console.WriteLine("Height: " + square.height);
            Console.WriteLine("The area of shape is: " + area);
        }
    }
}