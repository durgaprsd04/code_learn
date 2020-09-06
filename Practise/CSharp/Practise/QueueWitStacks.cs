using System;
public class QueueWitStacks<T> where T:class
{
    MyStack<T> stack1 = new MyStack<T>();
    MyStack<T> stack2 = new MyStack<T>();
    
    public void Enqueue(T element)
    {
        stack2.Push(element);
    }
    public T Dequeue()
    {
        var c2 = stack2.Pop();
        while(c2!=null){
            stack1.Push(c2);
            c2= stack2.Pop();
        }
        Console.WriteLine("popping done");
        var temp = stack1.Pop();
        c2 = stack1.Pop();
        while(c2!=null)
        {
            stack2.Push(c2);
            c2 = stack1.Pop();
        }
        return temp;
    }
}