using System;
using System.Threading;
namespace interview
{
    public class ListNode
    {
        public  int n;
        public ListNode next;
        public ListNode(int n, ListNode node)
        {
            this.n = n;
            this.next =node;
        }
        //public ListNode
    }
    public class interview2
    { 
        public void Method()
        {
            ListNode l=new ListNode(5,null);
            for(int i=4;i>0;i--)
            {
                l = new ListNode(i, l);
            }
            var l2 =l;
            Console.WriteLine("Before");
            while(l2!=null)
            {
                Console.Write(l2.n +"->");
                l2 = l2.next;
                //Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("After");
            var a = Reverse(l, 3);
            while(a!=null)
            {
                Console.Write(a.n +"->");
                a = a.next;
                //Console.ReadLine();
            }

        }
        public ListNode Reverse(ListNode head, int k)
        {
            int i=0;
            var b = head;
            ListNode backup=null,backup1=null,backup3=null;
            ListNode prev =null;
            while(b !=null)
            {
                prev =null;
                backup3=Deepcopy(b);
                //PrintNode(backup3);
                while(i!=k)
                {
                    var a = b;
                    PrintNode(backup3);
                    if(b!=null)
                    {
                        b = b.next;
                        a.next =prev;
                        prev = a;
                        i++;
                        PrintNode(backup3);
                        //PrintNode(b);
                    }
                    else
                    {
                        //PrintNode(backup3);
                        break;
                    }
                }
                
                if(i==k)
                {
                    if(backup==null)
                    {
                        backup =prev;
                        backup1 =backup;
                    }
                    else
                    {
                        backup.next =prev;
                    } 
                }
                else
                {
                    //PrintNode(backup3);
                    backup.next =backup3;
                }
                i=0;
                while(backup.next!=null)
                   backup=backup.next;
            }
           
            return backup1;
        }
         public void PrintNode(ListNode node)
        {
         var a = node;
            while(a!=null)
            {
                Console.Write(a.n +"->");
                a = a.next;
                
            }
            Console.WriteLine();
        }
        public ListNode Deepcopy(ListNode node)
        {
            var n = node;
            ListNode nod1 =null;
            if(node.next==null)
                return new ListNode(node.n, null);
            nod1 = new ListNode(node.n, Deepcopy(node.next));
            
            return nod1;
        }
        
    }
   
}