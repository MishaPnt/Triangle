using System;


namespace TTriangle
{
    class IsoscelesTrianglecs : Triangle
    {
        public IsoscelesTrianglecs(double a, double b, double angle) : base(a, b, angle)
        {
        }

        public override double Area()
        {
            return (1.0 / 2) * b * Math.Sqrt((a + (1.0 / 2) * b) * (a - (1.0 / 2) * b));
        }

        public override double Perimetr()
        {
            return 2 * a + b;
        }
    }
}
