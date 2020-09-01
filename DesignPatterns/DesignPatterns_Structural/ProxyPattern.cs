using System;
namespace DesignPatterns_Structural
{
    public abstract class IMath
    {
        public abstract double Add(double a , double b);
        public abstract double Sub(double a, double b);
        public abstract double Mul(double a , double b);
        public abstract double Div(double a , double b);

    }
    public class Math:IMath
    {
        public override double Add(double a, double b)
        {
            return a+b;
        }
    public override double Sub(double a, double b)
    {
        return a-b;
    }
    public override double Mul(double a , double b)
    {
        return a*b;
    }
    public override double Div(double a , double b)
    {
        return a/b;
    }

}
    public class MathProxy:IMath
    {
        private Math _math = new Math();
        public override double Add(double a, double b)
        {
            return _math.Add(a, b);
        }
        public override double Sub(double a, double b)
        {
            return _math.Sub(a, b);
        }
        public override double Mul(double a, double b)
        {
            return _math.Mul(a, b);
        }
        public override double Div(double a, double b)
        {
            return _math.Div(a, b);
        }
    }
}