using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class  TwoBinariesClass
    {
       public string AddBinary(string a, string b)
       {
          return ToBinary(a,b, "0");
       }
       public string ToBinary(string a, string b, string carry)
       {
         var len1 = a.Length;
         var len2 = b.Length;
         Console.WriteLine($"a {a} b {b}");
         if(len1==0 || len2==0)
         {
           if(carry=="0")
            return (len1==0)?b:a;
           else
           {
             var v1 = (len1==0)?b:a;
             var l = (len1==0)?len2:len1;
             return  ToBinary(v1, carry, "0");
           }
         }
         var a1 = a[len1-1];
         var b1 = b[len2-1];
         var res = AddBinary1(a1.ToString(),b1.ToString());
         var res1 = AddBinary1(res.sum, carry);
         if(res1.rem=="1")
           res.rem=res1.rem;
         return ToBinary(a.Substring(0,len1-1), b.Substring(0,len2-1), res.rem)+res1.sum;
       }
       (string sum,string rem) AddBinary1(string a1, string b1)
       {
         string sum=string.Empty, rem = string.Empty;
         if(a1=="1" && b1=="1") {sum="0"; rem="1";}
         if(a1=="1" && b1=="0") {sum="1"; rem="0";}
         if(a1=="0" && b1=="1") {sum="1"; rem="0";}
         if(a1=="0" && b1=="0") {sum="0"; rem="0";}
         return (sum,rem);
       }
    }
}
