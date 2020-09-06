using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MergeTwoSortedLists
    {

          public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
          {
                return MergeRecursive(l1,l2);
          }
          public ListNode MergeRecursive(ListNode l1, ListNode l2)
          {
            /*
            if(l1==null || l2 ==null)
              return null;
            ListNode l3 =null;
            if(l2.next==null || l1.next==null)
            {
               if(l1.next==null)
                  l3 = MergeRecursive(l1,l2.next);
               if(l2.next ==null)
                 l3 = MergeRecursive(l1.next, l2);
                Console.WriteLine($"inside next null l2.val : {l2.val} l1.val : {l1.val}");
                if(l2.val>l1.val)
                  {
                        if(l2.next==null)
                        {
                          l3 = new ListNode(l2.val);
                        }
                        else
                        {
                          l3 = new ListNode(l2.val, CopyFullNode(l2.next));
                        }
                  }
                else
                {
                  if(l1.next==null)
                  {
                    Console.WriteLine($"Created something with {l1.val}");
                    l3 = new ListNode(l1.val);
                  }
                  else
                  {
                    Console.WriteLine($"Crated val with {l1.val}");
                    l3 = new ListNode(l1.val, CopyFullNode(l1.next));
                  }
                }
              return l3;
            }
             Console.WriteLine($"l2.val : {l2.val} l1.val : {l1.val}");
             if(l1.val>l2.val)
             {
                if(l2.next!=null)
                  l3 = MergeRecursive(l1,l2.next);
             }
             else
             {
                if(l1.next==null)
                  l3 = MergeRecursive(l1.next,l2);
             }
             if(l3.val>l2.val)
                l3 = new ListNode(l2.val, l3);
             else
                l3 = new ListNode(l1.val, l3);
             return l3;
             */
          ListNode l3=null;
          if(l1==null && l2==null)
              return l3;
          if(l1==null || l2==null)
            return (l1==null)?l2:l1;
          if(l1!=null && l2!=null)
          {
            if(l1.val>l2.val)
            {
              l3 = new ListNode(l2.val, MergeRecursive(l1, l2.next));
            }
            else
            {
              l3 = new ListNode(l1.val,  MergeRecursive(l1.next,l2));
            }
          }
          return l3;
          }
          public ListNode CopyFullNode(ListNode l2)
          {
             ListNode l3;
              if(l2==null)
                return null;
             l3 = new ListNode(l2.val, CopyFullNode(l2.next));
             return l3;
          }
    }
}

