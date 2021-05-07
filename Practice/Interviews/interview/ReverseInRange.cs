using System;
using System.Threading;
namespace interview
{
    public class ReverseInRange
    {
        public void ReverseInRangeHelper()
        {
            ListNode l=new ListNode(5,null);
                for(int i=5;i>0;i--)
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
            var left =2;
            var right=4;
            var result = ReverseBetween(l, left, right);
            l2 =result;
            Console.WriteLine("Before");
            while(l2!=null)
            {
                Console.Write(l2.n +"->");
                l2 = l2.next;
                //Console.ReadLine();
            }
        }
        public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head==null)
            return null;
        var count=1;
        var b= head;
        var backup=b;
        ListNode prev=null;
        ListNode prev1=null;
        
        while(b !=null)
        {
            var a=b;
            if(b!=null && count<left)
            {
                prev1 =b;
            }
            //Console.Write(b.val);
            if(count<=right)
                b = b.next;
            if(count>=left && count<=right)
            {
                a.next = prev;
                prev = a;
            }
            if(count>right)
                break;
            count++;
        }
        //Console.WriteLine(b.val);
        
        if(prev1!=null)
        {
             prev1.next = prev;
             while(prev1.next!=null)
                prev1= prev1.next;
            prev1.next = b;
            return backup;
        }
        else
        {
            prev1=prev;
            while(prev1.next!=null)
                prev1= prev1.next;
            prev1.next = b;
            return prev;
        }
    }
        
    }
}