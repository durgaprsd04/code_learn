namespace DesignPatterns_Structural
{
    public abstract class AbstractShape
    {
        public double r;
        public AbstractShape(double r)
        {
            this.r=r;
        }
        public abstract double CalculateArea();
    }
    public class Circle:AbstractShape
    {
        public Circle(double r):base(r)
        {

        }
        public override double CalculateArea()
        {
            return r*r*3.14;
        }    
    }
    public class Square:AbstractShape
    {
        public Square(double r):base(r)
        {}
        public override  double CalculateArea()
        {
            return r*r;
        }    
    }
    public abstract class AbstractAreaCalculator
    {
        protected AbstractShape shape;
        public AbstractShape Shape
        {
            set{shape=value;}
        }
        public virtual double CalculateShapeArea()
        {
            return shape.CalculateArea();
        }
    }
    public class AreaCalculator:AbstractAreaCalculator
    {
        public override double CalculateShapeArea()
        {
            return shape.CalculateArea();
        }
    }
}