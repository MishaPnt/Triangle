
namespace Triangles
{
    abstract class Ttriangle
    {
        public abstract double Area();
        public abstract double Perimetr();

        protected double a;
        protected double b;
        protected double angle;

        public  Ttriangle( double a, double b, double angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
    }
}
