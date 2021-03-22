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
            AbstractTriangle baseTriangle = new BaseTriangle(a, b, angle);
            Console.WriteLine(baseTriangle.Area());
            Console.WriteLine("Периметр трикутника: ");
            Console.WriteLine(baseTriangle.Perimetr());
            Console.WriteLine("Пошук кута коли вiдомi всi сторони(кута А: ");
            Console.WriteLine(baseTriangle.GetAngleA());
            Console.WriteLine("Пошук кута коли вiдомi всi сторони(кута B: ");
            Console.WriteLine(baseTriangle.GetAngleB());
            AbstractTriangle rectangularTriangle = new RectangularTriangle( a, b, angle);
            Console.WriteLine("Площа прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.Area());
            Console.WriteLine("Периметр прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.Perimetr());
            Console.WriteLine("Гiпотенуза прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.HypotenuseRectangular());
            AbstractTriangle isoscelesTrianglecs = new IsoscelesTrianglecs(a, b, angle);
            Console.WriteLine("Рiвнобедрений трикутник: ");
            Console.WriteLine(isoscelesTrianglecs.Area()); 
            Console.WriteLine("Периметр Рiвнобедреного трикутника: ");
            Console.WriteLine(isoscelesTrianglecs.Perimetr());
            AbstractTriangle equilateralTriangle = new EquilateralTriangle(a, b, angle);
            Console.WriteLine("Рiвностороннiй трикутник: ");
            Console.WriteLine(equilateralTriangle.Perimetr());
            Console.WriteLine("Площа рiвносторонього трикутника: ");
            Console.WriteLine(equilateralTriangle.Area());
            Console.WriteLine("Периметр рiвносторонього трикутника: ");
            Console.WriteLine(equilateralTriangle.Perimetr());
        }
    }
}
