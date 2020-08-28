using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class  TwoBinariesClass
    {
       public string AddBinary(string a, string b)
       {
          return ToBinary(a1,b1, "0");
       }
       public string ToBinary(string a, string b, string carry)
       {
         var len1 = a.Length;
         var len2 = b.Length;
         if(len1==0 || len2==0)
            return (len1==0)?b:a;

         string sum="", rem="";
         var a1 = a[len1-1];
         var b1 = b[len2-1];
         if(a1=="1" && b1=="1") {sum="0"; rem="1";}
         if(a1=="1" && b1=="0") {sum="1"; rem="0";}
         if(a1=="0" && b1=="1") {sum="1"; rem="0";}
         if(a1=="0" && b1=="0") {sum="0"; rem="0";}
        return ToBinary(a.SubstR
       }
    }
}
