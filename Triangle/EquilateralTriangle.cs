using System;
using System.Collections.Generic;
using System.Text;
using Triangles;

namespace Triangle
{
    class EquilateralTriangle : GetTriangles
    {
        public EquilateralTriangle(int a, int b, int angle) : base(a, b, angle)
        {

        }
        public override double PerimetrEquilateral()
        {
            return 3 * a;
        }
        public override double AreaEquilateral()
        {
            return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
        }

        public override double Area => throw new NotImplementedException();

        public override int Perimetr => throw new NotImplementedException();

        public override double AngleA => throw new NotImplementedException();

        public override double AngleB => throw new NotImplementedException();

        public override double AreaRectangular()
        {
            throw new NotImplementedException();
        }

        public override double HypotenuseRectangular()
        {
            throw new NotImplementedException();
        }

        public override double TriangleIsoscel()
        {
            throw new NotImplementedException();
        }

    }
}
