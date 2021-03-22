using System;


namespace Triangles
{
    class IsoscelesTrianglecs : AbstractTriangle
    {
        public IsoscelesTrianglecs(int a, int b, int angle) : base(a, b, angle)
        {
        }
        public override double Area()
        {
            if (a == b || a == angle || b == angle)
                return (1 / 2) * b * Math.Sqrt((a + (1 / 2) * b) * (a - (1 / 2) * b));
            return 0;
        }

        public override double Perimetr()
        {
            return 2 * a + b;
        }

        public override double HypotenuseRectangular()
        {
            throw new NotImplementedException();
        }

        public override double GetAngleA()
        {
            throw new NotImplementedException();
        }

        public override double GetAngleB()
        {
            throw new NotImplementedException();
        }
    }
}
