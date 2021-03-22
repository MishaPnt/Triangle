using System;
namespace Triangles
{
    class RectangularTriangle : Getriangle
    {
        public RectangularTriangle(int a, int b, int angle) : base(a,b,angle)
        {
        }
        public override double Area() 
        {
            return (a * b) / 2;
        }

        public double HypotenuseRectangular()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public override double Perimetr()
        {
            return Math.Sqrt(a * 2 + b * 2) + a + b;
        }
    }
}
