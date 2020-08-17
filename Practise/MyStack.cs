using System;
public class MyStack<T> where T:class
{
  public Node<T> node1;   
    public void Push(T element){
        var newNode = new Node<T>(element);
        var temp = this.node1;
        this.node1 = newNode;
        this.node1.next= temp;
    }   
    public T Pop(){
        if(this.node1!=null)
        {
            var temp = this.node1;
            this.node1 = this.node1.next;
            return temp.element;
        }
       return null;
    }
    public void Traverse()
    {
        Console.Write(node1.element+",");
        if(node1.next!=null)
           Traverse(node1.next);
       
    }
    private void Traverse(Node<T> n)
    {
        if(n==null)
            return;
        Console.Write(n.element+",");
        Traverse(n.next);
    }
}
public class Node<T>  where T:class 
{
    public T element;
    public Node<T> next;
    public  Node(T element, Node<T> n =null)
    {
        this.element = element;
        this.next = null;
    }
}