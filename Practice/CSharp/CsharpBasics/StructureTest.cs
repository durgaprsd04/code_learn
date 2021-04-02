using System;
using System.Collections.Generic;
public struct Test{
    public  int a;
    public int b;

}
public class Test123
{
    public int a;   
    public int b;
    public void Method()
    {
        Console.WriteLine("hello world");
    }
   
    ~Test123()
    {
        Console.WriteLine("Desturctor caled");
    }

    public void IterativeStack(Stack<int> s)
    {
        var v = s.Pop();
        if(s.Count>0)
            IterativeStack(s, v);
    }
    public void IterativeStack(Stack<int> s, int a)
    {
        var v = s.Pop();
        if(s.Count>0)
            IterativeStack(s, a);
        else
            s.Push(a);
        s.Push(v);

    }
}
