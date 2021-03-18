using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class RectangularTriangle : GetTriangle
    {
        public RectangularTriangle(double heigth, double baseOfTriangle, int a, int b, int c, int y) : base(heigth,baseOfTriangle,a,b,c,y)
        {
        }
        public double AreaOfRectangularTriangle()
        {
            return (a * b) / 2;
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
