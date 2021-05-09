using System;
using System.Collections;
using System.Collections.Generic;
namespace CSharp.Basics
{
    public static class MyExtensions
    {
        public static string[] ToStringArray<T>(this List<T> list)
        {
            string[] array = new string[list.Count];

            for (int i = 0; i < list.Count; i++)
                array[i] = list[i].ToString();

            return array;
        }
        public static string JoinByCommas<T>(this List<T> list)
        {
            return string.Join(',', list.ToArray());
        } 
        public static string [] SplitByCommas(this string str)
        {
            return str.Split(',');
        }
        public static string JoinBySemicolons<T>(this List<T> list)
        {
            return string.Join(";", list.ToArray());
        }
    }

    public class TestExtMethod
    {
        public void TestExtMethod1()
        {
        List<string> str = new List<string>();
        str.Add("abc");
        str.Add("efg");
        str.Add("hij");
        var str1 = "once, upon,a timea,a";
        var a = new List<int> {3,4,5};
        Console.WriteLine($"String join { string.Join(',',a.ToStringArray()) }");
        Console.WriteLine($"String join { string.Join(',',str.ToStringArray()) }");
         Console.WriteLine($"String join {str.JoinByCommas()}");
          Console.WriteLine($"String join {str.JoinBySemicolons()}");
         Console.WriteLine($"String join { string.Join(',',str1.SplitByCommas()) }");
        }

    }
}
