using System;
namespace CSharp.FuncTypes
{            
    public delegate void testdelegate(string test);

    public class  DelegateTest
    {

    public  void test1(string name) => Console.WriteLine("welcome " + name);

    public  void test2(string name)
    {
        Console.WriteLine("hello "+name);
    }
    }
    
}