using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class Square:AFigure, IFigure
    {
        private readonly double _side;
        
        public Square(double side)=>_side = side;
        
        public double CalcPerimeter()
        {
            Perimeter = 4 * _side;
            return Perimeter;
        }
        public double CalcArea()
        {
            Area = _side * _side;
            return Area;
        }

    }
}
