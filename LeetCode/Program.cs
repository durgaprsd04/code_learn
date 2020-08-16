using System;
using System.IO;
namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Solution sol = new Solution();
            //int [] a = {1,1,1};
            //Console.WriteLine("sum" +string.Join(',', sol.RunningSum(a)));
            /*ListNode l = new ListNode(5);
            //l.next = new ListNode(4);
            //l.next.next= new ListNode(3);
            l.Traverse();
            ListNode l1 = new ListNode(5);
            //l1.next = new ListNode(6);
            //l1.next.next= new ListNode(4);
            l1.Traverse();
            */
            /*Solution2 sn = new Solution2();
            StreamReader sr = new StreamReader("input_longestsubstring.txt");
            while(sr.Peek()>0)
            {
                var l2 = sn.LengthOfLongestSubstring(sr.ReadLine());
                Console.WriteLine(l2);
            }
            */
            /*
            StreamReader sr = new StreamReader("input_longestpal.txt");
            Solution3 s3 = new Solution3();
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine();
              Console.WriteLine(v);
              var l2 = s3.LongestPalindrome(v);
              Console.WriteLine(l2);
            }
            */
             StreamReader sr = new StreamReader("input_zigzag.txt");
            ZigZag s4 = new ZigZag();
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(' ');;
              Console.WriteLine(v[0] +" : "+v[1]);
              var l2 = s4.Convert(v[0], Convert.ToInt32( v[1]));
              Console.WriteLine(l2);
            }

        }
    }
}
