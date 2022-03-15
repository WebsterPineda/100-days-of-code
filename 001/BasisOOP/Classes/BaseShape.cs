using BasisOOP.Interfaces;
using System;

namespace BasisOOP.Classes
{
    public abstract class BaseShape : IFlatShape
    {
        private double _width;
        private double _height;
        public BaseShape()
        {
            _width = 0;
            _height = 0;
        }

        public BaseShape(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double width { get {return _width;} }
        public double height { get {return _height;} }

        public abstract double Area();
        
    }
}