using System;
using Triangle;

namespace TTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Висота: ");
            double heigth = double.Parse(Console.ReadLine());
            Console.WriteLine("Основа Трикутника: ");
            double baseOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Дві сторони та кут між ними: ");
            int y = int.Parse(Console.ReadLine());
            GetTriangle getTriangle = new GetTriangle(heigth, baseOfTriangle, a,b,c,y);
            Console.WriteLine("Площа трикутника: ");
            Console.WriteLine(getTriangle.GetArea());
            Console.WriteLine("Периметр трикутника: ");
            Console.WriteLine(getTriangle.GetPerimetr());
            Console.WriteLine("Дві сторони та кут між ними: ");
            Console.WriteLine(getTriangle.GetUnknownPart());
            Console.WriteLine("Пошук кута коли відомі всі сторони(кута А: ");
            Console.WriteLine(getTriangle.GetAngleA());
            Console.WriteLine("Пошук кута коли відомі всі сторони(кута B: ");
            Console.WriteLine(getTriangle.GetAngleB());
            RectangularTriangle rectangularTriangle = new RectangularTriangle(heigth, baseOfTriangle, a, b, c, y);
            Console.WriteLine("Площа прямокутного трикутника: ");
            Console.WriteLine(rectangularTriangle.AreaOfRectangularTriangle());
            Console.WriteLine("Гiпотенуза: ");
            Console.WriteLine(rectangularTriangle.Hypotenuse());
        }
    }
}
