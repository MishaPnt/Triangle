using System;
using Triangle;
using Triangles;

namespace TTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сторона а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Кут: ");
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine("Площа трикутника: ");
            Ttriangle rectangularTriangle = new RectangularTriangle( a, b);
            Console.WriteLine("Площа прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.Area());
            Console.WriteLine("Периметр прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.Perimetr());
            Ttriangle isoscelesTrianglecs = new IsoscelesTrianglecs(a, b, angle);
            Console.WriteLine("Рiвнобедрений трикутник: ");
            Console.WriteLine(isoscelesTrianglecs.Area()); 
            Console.WriteLine("Периметр Рiвнобедреного трикутника: ");
            Console.WriteLine(isoscelesTrianglecs.Perimetr());
            Ttriangle equilateralTriangle = new EquilateralTriangle(a);
            Console.WriteLine("Рiвностороннiй трикутник: ");
            Console.WriteLine(equilateralTriangle.Perimetr());
            Console.WriteLine("Площа рiвносторонього трикутника: ");
            Console.WriteLine(equilateralTriangle.Area());
            Console.WriteLine("Периметр рiвносторонього трикутника: ");
            Console.WriteLine(equilateralTriangle.Perimetr());
        }
    }
}
