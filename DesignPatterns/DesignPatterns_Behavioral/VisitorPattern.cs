using System;
using System.Collections.Generic;
public interface IVisitor 
{
    void Visit(Elements emp);
}
public class VacationVisitor:IVisitor
{
     public  void Visit(Elements emp)
    {
        var element =emp as Employee;
        element.Hols+=5;
    }
    
}

public class PayVisitor:IVisitor
{
    public  void Visit(Elements emp)
    {
        var element =emp as Employee;
        element.BasePay+=5000;
    }
}

public interface Elements
{
    void Accept(IVisitor visitor);
}
public class Employee:Elements
{
    
    private string  name;
    private double basePay;
    private int hols;
    public string Name{
        set{this.name=value;}
        get{return this.name;}
    }
    public double BasePay{
        set{this.basePay=value;}
        get{return this.basePay;}
    }
    public int Hols{
        set{this.hols=value;}
        get{return this.hols;}
    }
    public Employee(string name, double pay, int hols)
    {
        this.name=name;
        this.basePay=pay;
        this.hols=hols;
    }
    public  void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    public void Show()
    {
        Console.WriteLine("{0}'s pay is {1} with holiday {2}",name, basePay, hols);
    }
}
public class Employees
{

    List<Elements> elements = new List<Elements>();

    public void Add(Elements emp)
    {
        elements.Add(emp);
    }
    public void Accept(IVisitor visitor)
    {
        foreach(var e in elements)
        {
            e.Accept(visitor);
        }
    }
    public void ShowEmployees()
    {
        foreach(var e in elements)
        {
            var e1 = e as Employee;
            e1.Show();
        }
    }
}

public class President:Employee
{
    public President(string name, double pay, int hols):base(name, pay, hols)
    {

    }
}
public class Director:Employee
{
    public Director(string name, double pay, int hols):base(name, pay, hols)
    {
        
    }
}
public class Clerk:Employee
{
    public Clerk(string name, double pay, int hols):base(name, pay, hols)
    {
        
    }
}