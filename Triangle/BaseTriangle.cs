using System;
using System.Collections.Generic;
using System.Text;
using Triangles;

namespace Triangle
{
    class BaseTriangle : AbstractTriangle
    {
        public BaseTriangle(int a, int b, int angle) : base(a, b, angle)
        {

        }

        public override double Area()
        {
            return 1.0 / 2 * a * b;
        }

        public override double Perimetr()
        {
            return a + b + angle;
        }

        public override double GetAngleA() // Search for an angle when all sides are known (angle A)
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(angle, 2) - Math.Pow(a, 2)) / (2 * b * angle));
        }

        public override double GetAngleB() // Search for an angle when all sides are known (angle )
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(angle, 2) - Math.Pow(b, 2)) / (2 * a * angle));
        }

        public override double HypotenuseRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
