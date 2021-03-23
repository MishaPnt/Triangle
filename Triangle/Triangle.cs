
namespace TTriangle
{
    abstract class Triangle
    {
        public abstract double Area();
        public abstract double Perimetr();

        protected double a;
        protected double b;
        protected double angle;

        public  Triangle( double a, double b, double angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
    }
}
