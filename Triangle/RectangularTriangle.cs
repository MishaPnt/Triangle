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

        public override double AreaOfRectangularTriangle() 
        {
            return (a * b) / 2;
        }
        public override double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        public override double TriangleIsoscel()
        {
            throw new NotImplementedException();
        }
    }
}
