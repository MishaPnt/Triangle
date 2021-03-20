using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    abstract class GetTriangles
    {
        public abstract double Area { get; }

        public abstract int Perimetr { get; }

        public abstract double AngleA { get; }

        public abstract double AngleB { get; }
        public abstract double AreaRectangular();
        public abstract double HypotenuseRectangular();
        public abstract double TriangleIsoscel();
        public abstract double PerimetrEquilateral();
        public abstract double AreaEquilateral();


        public int a;
        public int b;
        public int angle;
        public  GetTriangles( int a, int b, int angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
        public double AreaTriangle()
        {
            return 1.0 / 2 * a * b;
        }
        public int PerimetrTriangle()
        {
            return a + b + angle;
        }
        public  double GetAngleA() // Search for an angle when all sides are known (angle A)
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(angle, 2) - Math.Pow(a, 2)) / (2 * b * angle));
        }
        public  double GetAngleB() // Search for an angle when all sides are known (angle )
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(angle, 2) - Math.Pow(b, 2)) / (2 * a * angle));
        }
    }
}
