using System;


namespace Triangles
{
    class IsoscelesTrianglecs : Getriangle
    {
        public IsoscelesTrianglecs(int a, int b, int angle) : base(a, b, angle)
        {
        }

        public override double Area()
        {
            return (1.0 / 2) * b * Math.Sqrt((a + (1 / 2) * b) * (a - (1 / 2) * b));
        }

        public override double Perimetr()
        {
            return 2 * a + b;
        }
    }
}
