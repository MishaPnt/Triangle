using System;
using Triangles;

namespace Triangle
{
    class EquilateralTriangle : Ttriangle
    {
        public EquilateralTriangle(double a) : base(a,a,90)
        {
        }

        public override double Perimetr()
        {
            return 3 * a;
        }

        public override double Area()
        {
            return (a*a * Math.Sqrt(3)) / 4;
        }
    }
}
