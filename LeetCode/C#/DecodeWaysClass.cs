using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class DecodeWaysClass
    {
        public static int level=0;
        public int NumDecodings(string s) {

            Console.Write($"string {s}  "); 
            if(s.Length==1)
                return 1;
            var firstCount=0;
            if(!s.Contains('0'))
                firstCount=1;
            var sum=0;
            for(int i=0;i<s.Length-1;i++)
            {
                sum += NumDecodings(s.Substring(0,i));
                //+ NumDecodings(s.Substring(i,2))+ NumDecodings(s.Substring(i+2, (s.Length-i-2)));
            }
            return firstCount+sum;
    }
    }
}