using  System;
namespace Practise
{
    public class MyQueue<T> where  T : class
    {
    T element;
    MyQueue<T> node;
    public void Enqueue(T element1)
    {
       if(this.element==null)
       {
           this.element=element1;
           this.node=new MyQueue<T>();
       }            
        else
        {
            this.node.Enqueue(element1);
        }
    }
    public void Traverse()
    {
        Console.Write(this.element +",");        
        if(this.node==null)
            return;  
        node.Traverse();      
    }
    public T DeQueue()
    {
        if(this.element!=null)
        {
            var temp=this.element;
            this.element=this.node.element;
            this.node= this.node.node;
            return temp;
        }
        return  null;
    }
    }
}
