
namespace Triangles
{
    abstract class Getriangle
    {
        public abstract double Area();
        public abstract double Perimetr();

        protected int a;
        protected int b;
        protected int angle;

        public  Getriangle( int a, int b, int angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
    }
}
