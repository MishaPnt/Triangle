﻿using System;
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
            GetTriangles getTriangles = new RectangularTriangle(a, b, angle);
            Console.WriteLine(getTriangles.AreaTriangle());
            Console.WriteLine("Периметр трикутника: ");
            Console.WriteLine(getTriangles.PerimetrTriangle());
            Console.WriteLine("Пошук кута коли вiдомi всi сторони(кута А: ");
            Console.WriteLine(getTriangles.GetAngleA());
            Console.WriteLine("Пошук кута коли вiдомi всi сторони(кута B: ");
            Console.WriteLine(getTriangles.GetAngleB());
            RectangularTriangle rectangularTriangle = new RectangularTriangle( a, b, angle);
            Console.WriteLine("Площа прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.AreaRectangular());
            Console.WriteLine("Гiпотенуза прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.HypotenuseRectangular());
            Console.WriteLine("Рiвнобедрений трикутник: ");
            Console.WriteLine(rectangularTriangle.TriangleIsoscel());
            Console.WriteLine("Рiвностороннiй трикутник: ");
            Console.WriteLine(rectangularTriangle.PerimetrEquilateral());
            Console.WriteLine(rectangularTriangle.AreaEquilateral());
        }
    }
}
