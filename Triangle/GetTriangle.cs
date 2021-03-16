using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{

    class GetTriangle : Triangle
    {

        public double heigth;
        public double baseOfTriangle;
        public int a;
        public int b;
        public int c;
        public GetTriangle(double heigth, double baseOfTriangle, int a, int b, int c)
        {
            this.heigth = heigth;
            this.baseOfTriangle = baseOfTriangle;
            this.a = a;
            this.b = b;
            this.c = c;

        }
        override public double GetArea()
        {
            return 1.0 / 2 * baseOfTriangle * heigth;
        }
        override public int GetPerimetr()
        {
            return a + b + c;
        }
    }
    abstract class Triangle
    {
        abstract public double GetArea();
        abstract public int GetPerimetr();
    }
}
