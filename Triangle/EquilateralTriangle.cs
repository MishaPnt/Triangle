using System;
using System.Collections.Generic;
using System.Text;
using Triangles;

namespace Triangle
{
    class EquilateralTriangle : AbstractTriangle
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
