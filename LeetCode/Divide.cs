using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class DivideClass
    {
      public int Divide(int a, int b)
      {
         bool isAneg =false;
         bool isBneg =false;
         bool breakFlag=false;
          var str = a.ToString();
            if(str.Contains('-'))
            {
              str= str.Replace("-","");
              isAneg=true;
            }
          var str2 = b.ToString();
            if(str2.Contains('-'))
            {
              isBneg=true;
              str2 = str2.Replace("-","");
            }
          var b1 = Convert.ToInt32(str2);
          var len = str.Length;
          var rem = 0;
          int quotient = 0;
          int i=1;
          while(i<=len)
          {
            //Console.WriteLine($"index {index} i {i}");
            var result = TryDivide(Convert.ToInt32(str.Substring(i-1,1))+Convert.ToInt32((rem.ToString()+"0")), b1);
            rem = result.r;
            Console.WriteLine($"q {quotient}");
            if((quotient*10+result.q)>Int32.MaxValue)
            {
              breakFlag=true;
              quotient = Int32.MaxValue;
              break;

            }
            quotient = quotient*10 + result.q;
            i++;
          }
          if(!breakFlag&&( isBneg^isAneg))
            quotient= -1*quotient;
          return quotient;
      }
      (int q, int r, bool dividePossible) TryDivide(int a, int b)
      {
        //Console.WriteLine($"a {a}, b {b}");
          int i = 0;
          bool isDivide=false;
          while(a>=b)
          {
            a = a-b;
            i++;
            isDivide=true;
          }
          //Console.WriteLine($"q {i}");
          return (i,a,isDivide);
      }
    }
}
