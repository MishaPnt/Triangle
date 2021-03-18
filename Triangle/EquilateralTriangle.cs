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

        public override double Area => throw new NotImplementedException();

        public override int Perimetr => throw new NotImplementedException();

        public override double AngleA => throw new NotImplementedException();

        public override double AngleB => throw new NotImplementedException();

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
            throw new NotImplementedException();
        }

    }
}
