using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    public class Circle:AFigure, IFigure
    {
        public const double PI = 3.14;

        private readonly double _radius;
        
        public Circle(double radius)=> _radius = radius;
        
        public double CalcPerimeter()
        {
            Perimeter = 2 * PI * _radius;
            return Perimeter;
        }
        public double CalcArea()
        {
            Area = PI * _radius * _radius;
            return Area;

        }
    }
}
