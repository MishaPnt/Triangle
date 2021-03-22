using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    abstract class AbstractTriangle
    {
        public abstract double Area();
        public abstract double Perimetr();
        public abstract double HypotenuseRectangular();
        public  abstract double GetAngleA();
        public abstract double GetAngleB();

        protected int a;
        protected int b;
        protected int angle;
        public  AbstractTriangle( int a, int b, int angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
    }
}
