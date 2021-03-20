using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    class RectangularTriangle : GetTriangles
    {
        public RectangularTriangle(int a, int b, int angle) : base(a,b,angle)
        {
        }

        public override double Area => throw new NotImplementedException();

        public override int Perimetr => throw new NotImplementedException();

        public override double AngleA => throw new NotImplementedException();

        public override double AngleB => throw new NotImplementedException();

        public override double AreaRectangular() 
        {
            return (a * b) / 2;
        }

        public override double HypotenuseRectangular()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public override double PerimetrRectangular()
        {
            return Math.Sqrt(a * 2 + b * 2) + a + b;
        }

        public override double AreaEquilateral()
        {
            throw new NotImplementedException();
        }

        public override double AreaIsoscel()
        {
            throw new NotImplementedException();
        }

        public override double AreaIsosceles()
        {
            throw new NotImplementedException();
        }

        public override double PerimetrIsosceles()
        {
            throw new NotImplementedException();
        }

        public override double PerimetrEquilateral()
        {
            throw new NotImplementedException();
        }
    }
}
