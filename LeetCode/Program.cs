using System;
using System.IO;
using System.Linq;
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
            *//*
             streamreader sr = new streamreader("input_zigzag.txt");
            zigzag s4 = new zigzag();
            while(sr.peek()>0)
            {
              var v = sr.readline().split(' ');;
              console.writeline(v[0] +" : "+v[1]);
              var l2 = s4.convert(v[0], convert.toint32( v[1]));
              console.writeline(l2);
            }*/
            /*
            StreamReader sr = new StreamReader("input_container.txt");
            ContainerWater wt  = new ContainerWater();
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var l2  = wt.MaxArea(v);
              Console.WriteLine(l2);
            }
            */
            StreamReader sr = new StreamReader(@"inputs\input_roman.txt");
            NumberToRoman nr  = new NumberToRoman();
             Console.WriteLine("hello");
            while(sr.Peek()>0)
            {             
              var v = Convert.ToInt32(sr.ReadLine());
              var l2  = nr.IntToRoman(v); 
              Console.WriteLine(v +" : "+l2);            
            }
             


        }
    }
}
