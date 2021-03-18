using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    abstract class Triangle
    {
        abstract public double GetArea();
        abstract public int GetPerimetr();
        abstract public double GetUnknownPart();
        abstract public double GetAngleA();
        abstract public double GetAngleB();
    }
    class GetTriangle : Triangle //https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BE%D1%80%D0%B5%D0%BC%D0%B0_%D0%BA%D0%BE%D1%81%D0%B8%D0%BD%D1%83%D1%81%D1%96%D0%B2
    {
         double heigth;
         double baseOfTriangle;
         public int a;
         public int b;
         public int c;
         public int y;
        public GetTriangle(double heigth, double baseOfTriangle, int a, int b, int c,int y)
        {
            this.heigth = heigth;
            this.baseOfTriangle = baseOfTriangle;
            this.a = a;
            this.b = b;
            this.c = c;
            this.y = y;
        }
        override public double GetArea()
        {
            return 1.0 / 2 * baseOfTriangle * heigth;
        }
        override public int GetPerimetr()
        {
            return a + b + c;
        }
        override public double GetUnknownPart() //Two sides and the angle between them. When the 3rd party is unknown
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(y));
        }
        override public double GetAngleA() // Search for an angle when all sides are known (angle A)
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2))/(2*b*c));
        }
        override public double GetAngleB() // Search for an angle when all sides are known (angle )
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
        }
    }
}
