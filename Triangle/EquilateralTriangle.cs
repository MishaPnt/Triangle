using System;
using Triangles;

namespace Triangle
{
    class EquilateralTriangle : Getriangle
    {
        public EquilateralTriangle(int a, int b, int angle) : base(a, b, angle)
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
