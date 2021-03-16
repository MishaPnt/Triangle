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
            GetTriangle getTriangle = new GetTriangle(heigth, baseOfTriangle, a, b, c);
            Console.WriteLine("Площа трикутника: ");
            Console.WriteLine(getTriangle.GetArea());
            Console.WriteLine("Периметр трикутника: ");
            Console.WriteLine(getTriangle.GetPerimetr());

        }
    }
}
