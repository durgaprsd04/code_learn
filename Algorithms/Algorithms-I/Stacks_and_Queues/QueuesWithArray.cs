using System;
namespace Stacks_and_Queues
{
    public class QueuesWithArray
    {
     private string [] s = new string [1];
     private int first=0,last=0, N=0;
     public void Enqueue(string var)
     {
        s[last++]=var;
        N++;
        if(N>=s.Length)
            Resize(s.Length*2);
        //Console.WriteLine(string.Join(",",s));
     }   
     public string Dequeue()
     {
        var itemkey = s[first];
         N--;
         if(N<s.Length/4)
            Resize(s.Length/2);
            //Console.WriteLine(string.Join(",",s)+' '+first);
        first++;
        return itemkey;
     }
     public void Resize(int size)
     {
         string [] s1 = new string [size];
         for(int i=first;i<last;i++)
         {
             s1[i-first]=s[i];
         }  
        first =0;
        last =N;
        s=s1;
     }
     public bool isEmpty()
     {
         return first==last;
     }
    }
}