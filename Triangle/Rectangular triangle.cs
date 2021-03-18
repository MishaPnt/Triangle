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
        public double AreaOfRectangularTriangle() //https://www.calculat.org/ua/%D0%BF%D0%BB%D0%BE%D1%89%D0%B0-%D0%BF%D0%B5%D1%80%D0%B8%D0%BC%D0%B5%D1%82%D1%80/%D0%BF%D1%80%D1%8F%D0%BC%D0%BE%D0%BA%D1%83%D1%82%D0%BD%D0%B8%D0%B9-%D1%82%D1%80%D0%B8%D0%BA%D1%83%D1%82%D0%BD%D0%B8%D0%BA.html
        {
            return (a * b) / 2;
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
