using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace LeetCode
{
    public class MinWindowClass
    { 

        public string MinWindow(string s, string t) {

            if(t.Length>s.Length)
            return string.Empty;

            var res = new StringBuilder(t);
            var len = t.Length;
            int index =0,end=0, begin=0, start =0;
            for(int i=0;i<s.Length;i++)
            {
                if(t.Contains(s[i]) && t!=string.Empty)
                {          
                    if(t.Length==len)
                        start =i;         
                    t = t.Replace(s[i].ToString(), "");                   
                    index=i;
                    Console.WriteLine($" index {index} t {t}");
                }   
                if(string.IsNullOrWhiteSpace(t))
                {      
                    begin = start;              
                    end =index;
                    t = res.ToString();
                }
                
            }
            Console.WriteLine($"begin {begin } end {end}");
            Console.WriteLine($" string {s.Substring(begin, end-begin+1)} ");
            return s.Substring(begin, end-begin+1);
        
        }
    }
}