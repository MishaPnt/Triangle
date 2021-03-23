using System;
using Triangles;

namespace Triangle
{
    class EquilateralTriangle : Ttriangle
    {
        public EquilateralTriangle(double a, double b, double angle) : base(a, b, angle)
        {
        }

        public override double Perimetr()
        {
            return 3 * a;
        }

        public override double Area()
        {
            return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
        }
    }
}
