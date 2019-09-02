using System;
public abstract class AbstractShape
{
    protected double _side;
    public abstract void CalculateArea();
    public abstract  void CalculatePerimeter();
    public void Calculate()
    {
        this.CalculateArea();
        this.CalculatePerimeter();
    }
    public  AbstractShape(double r)
    {
        _side=r;
    }
}
public class Circle:AbstractShape
{
    public Circle(double r):base(r)
    {

    }
    public override void CalculateArea()
    {
        Console.WriteLine("Area of the circle " +(_side*_side*Math.PI));
    }
    public override void CalculatePerimeter()
    {
        Console.WriteLine("Perimeter of the circle " +(2*_side*Math.PI));
    }
}
public class Square:AbstractShape
{
    public Square(double d):base(d)
    {

    }
    public override void CalculateArea()
    {
        Console.WriteLine("Area of the Square " +(_side*_side));
    }
    public override void CalculatePerimeter()
    {
        Console.WriteLine("Perimeter of the Square " +(4*_side));
    }
}