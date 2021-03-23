using System;

namespace TTriangle
{
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b) : base(a,b,90)
        {
        }
        public override double Area() 
        {
            return (a * b) / 2;
        }

        public override double Perimetr()
        {
            return Math.Sqrt(a * 2 + b * 2) + a + b;
        }
    }
}
