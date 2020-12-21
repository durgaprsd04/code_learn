using System.Collections;
using System.Collections.Generic;
using System;
namespace CSharp
{
    public class StringManip
    {
        public void TestFunc()
        {
            string a = "hello";
            string b= a;
            string c = string.Empty;
            //b=c;
            Console.WriteLine($" a{a} b{b} c{c}");
            update(ref a);
            Console.WriteLine($" a{a} b{b} c{c}");
        }
        public void update(ref string a)
        {
            a = "hello world";
            
        }
    }
}
