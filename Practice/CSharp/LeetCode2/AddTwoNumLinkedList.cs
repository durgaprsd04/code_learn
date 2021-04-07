using System;
 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }
  public class Solution
  {
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            
        var l3 = l1;
        var l1Length =0;
        var l4 = l2;
        var l2Length =0;
        while(l3.next!=null)
        {
            l3 = l3.next;
            l1Length++;
        }
        while(l4.next!=null)
        {
            l4 = l4.next;
            l2Length++;
        }
        var result = AddTwoNum(l1, l2, l1Length, l2Length);
        if(result.rem!=0)
        {
            return new ListNode(result.rem, result.node);
        }
        return result.node;
            
        
        }
    public (ListNode node, int rem) AddTwoNum(ListNode l1, ListNode l2, int a, int b)
    {       
        if(l1.next==null || l2.next==null)
        {
            var sum = l1.val + l2.val;
            var nodeVal = sum%10;
            return (new ListNode(nodeVal,null),sum/10);
        }
        
        (ListNode node, int  rem) result;
        if(a==b)
            result  = AddTwoNum(l1.next, l2.next, a-1,b-1);
        else if(a>b)
            result = AddTwoNum(l1.next, l2, a-1, b);
        else 
            result =  AddTwoNum(l1, l2.next, a, b-1);
        
        var sum1=l1.val+ l2.val;
        if(result.rem!=0)
        {
            var temp = sum1+result.rem;
            var nodeVal = temp%10;
            return (new ListNode(nodeVal, result.node), temp/10);
        }
        else
        {
            return (new ListNode(sum1, result.node), 0);
        }
      }
  }
  