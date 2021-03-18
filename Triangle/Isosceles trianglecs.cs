using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Isosceles_trianglecs :GetTriangle
    {

        public Isosceles_trianglecs(double heigth, double baseOfTriangle, int a, int b, int c, int y) : base(heigth, baseOfTriangle, a, b, c, y)
        {
        }
        public double AreaOfIsoscelesTrianglecs() //https://profmeter.com.ua/communication/learning/course/course25/lesson965/
        {
            return (1 / 2) * b * Math.Sqrt((a + (1 / 2) * b) * (a - (1 / 2) * b));
        }
        public double TriangleIsoscel()
        {
            if (a == b || a == c || b == c)
                return AreaOfIsoscelesTrianglecs();
            return 0;
        }

    }
}
