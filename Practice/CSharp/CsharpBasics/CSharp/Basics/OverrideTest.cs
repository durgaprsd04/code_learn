using System;
namespace CSharp.Basics
{
    public class Class1
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method 1- base class");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Method 2 - base class");
        }
    }
    public class Class2  : Class1
    {
        public  override void Method1()
        {
            Console.WriteLine("Method 1- derived class");
        }
        public new void Method2()
        {
            Console.WriteLine("Method 2- derived class");
        }
    }
    public class OverrideActionClass
    {
        public void OverrideAction()
        {
            Class1 class1 = new Class1();
            Class1 class2 = new Class2();
            Class2 class3 = new Class2();
            class1.Method1();
            class1.Method2();
            class2.Method1();
            class2.Method2();
            class3.Method1();
            class3.Method2();
        }
    }
}