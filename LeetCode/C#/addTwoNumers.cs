using System;
namespace LeetCode{
//  Definition for singly-linked list.

public class Solution1 {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var l3=l1;
        var l4=l2;
        string v1="";
        while(l3!=null)
        {
          Console.WriteLine(l3.val);
          v1=v1+ l3.val.ToString();
          l3=l3.next;
        }
        string v2="";
        Console.WriteLine("digit 1 "+v1);
        while(l4!=null)
        {
        v2 = v2+ l4.val.ToString();
        l4=l4.next;
        }
        Console.WriteLine("digit 2 "+v2);
        var v1array = v1.ToCharArray();
        var v2array = v2.ToCharArray();
        var maxLength = (v1.Length>v2.Length)?v1.Length:v2.Length;
        char []  v3array = new char [maxLength+1];
        var result=0;
        var reminder =0;
        for(int i=0;i<maxLength;i++)
        {
         if(i<v1array.Length && i<v2array.Length)
         {
            //Console.WriteLine("remin "+reminder);
            result =Convert.ToInt32( v1array[i].ToString())+Convert.ToInt32( v2array[i].ToString())+reminder;
            Console.WriteLine($"res{Convert.ToInt32( v1array[i].ToString())} + {v2array[i]} remin {reminder} "+result);
            reminder=0;
            if(result>=10)
            {
              var tempresult   = result%10;
              reminder = result/10;
              result=tempresult;
              //Console.WriteLine($"rrmin {reminder} result {result}");
            }
            v3array[i]=Convert.ToChar(result.ToString());
            //Console.WriteLine("result "+v3array[i]);
            result=0;
         }
         else
         {
            if(i < v2array.Length)
            {
              if(reminder==0)
              {
               v3array[i] = v2array[i];
              }
              else
              {
                result = Convert.ToInt32(v2array[i].ToString())+reminder;
                reminder=0;
                if(result>=10)
                {
                  var tempresult = result%10;
                  reminder=result/10;
                  result = tempresult;
                }
                v3array[i]=Convert.ToChar(result.ToString());
                result=0;
              }
            }
            else
            {
              if(reminder==0)
              {
              v3array[i]=v1array[i];
              }
              else
              {
                result = Convert.ToInt32(v1array[i].ToString())+reminder;
                reminder=0;
                if(result>=10)
                {
                  var tempresult = result%10;
                  reminder = result/10;
                  result=tempresult;
                }
                v3array[i]=Convert.ToChar(result.ToString());
                result=0;
              }
            }
         }
        }
        var l5 = new ListNode(Convert.ToInt32(v3array[0].ToString()));
        var l6 = l5;
        int k=0;
        for(int i=1;i<maxLength;i++)
        {
          l5.next = new ListNode(Convert.ToInt32(v3array[i].ToString()));
          l5 = l5.next;
          k=i;
        }
        if(reminder>0)
        {
          l5.next = new ListNode(Convert.ToInt32(reminder.ToString()));
          l5 = l5.next;
        }
        l6.Traverse();
        return l6;
    }
}
}
