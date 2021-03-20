using System;


namespace Triangles
{
    class IsoscelesTrianglecs : GetTriangles
    {
        public IsoscelesTrianglecs(int a, int b, int angle) : base(a, b, angle)
        {
        }
        public override double Area => throw new NotImplementedException();

        public override int Perimetr => throw new NotImplementedException();

        public override double AngleA => throw new NotImplementedException();

        public override double AngleB => throw new NotImplementedException();


        public override double AreaIsosceles()
        {
            return (1 / 2) * b * Math.Sqrt((a + (1 / 2) * b) * (a - (1 / 2) * b));
        }

        public override double AreaIsoscel()
        {
            if (a == b || a == angle || b == angle)
                return AreaIsosceles();
            return 0;
        }

        public override double PerimetrIsosceles()
        {
            return 2 * a + b;
        }

        public override double AreaRectangular()
        {
            throw new NotImplementedException();
        }

        public override double HypotenuseRectangular()
        {
            throw new NotImplementedException();
        }

        public override double AreaEquilateral()
        {
            throw new NotImplementedException();
        }

        public override double PerimetrEquilateral()
        {
            throw new NotImplementedException();
        }

        public override double PerimetrRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
