using System;
using System.Collections.Generic;
using System.Text;
using Triangles;


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

        public double AreaOfIsoscelesTrianglecs()
        {
            return (1 / 2) * b * Math.Sqrt((a + (1 / 2) * b) * (a - (1 / 2) * b));
        }

        public override double AreaOfRectangularTriangle()
        {
            throw new NotImplementedException();
        }

        public override double Hypotenuse()
        {
            throw new NotImplementedException();
        }
        public override double TriangleIsoscel()
        {
            if (a == b || a == angle || b == angle)
                return AreaOfIsoscelesTrianglecs();
            return 0;
        }
    }
}
