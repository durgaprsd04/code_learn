using System;
namespace LeetCode{
//  Definition for singly-linked list.
  
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
      public void Traverse()
      {
        Console.Write(val+"->");
        if(next!=null)
          next.Traverse();
        else
          Console.WriteLine();
      }
  }
}
