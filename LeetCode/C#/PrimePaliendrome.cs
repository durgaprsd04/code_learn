using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class PrimePaliendromeClass
    {
       public int PrimePalindrome(int N)
       {
         var maxInt = 200000000;
         var res=0;
         int i=N;
         if(N==1)
           return 2;
         while(i< maxInt)
         {
              if(IsPrime(i) && IsPal(i))
              {
                res=i;
                break;
              }
              //Console.WriteLine("sfdd");
              i=nextPal(i);
         }
         return res;
       }
       public int nextPal(int a)
       {
          int res =a+1;
          if(a<=9)
            res= a+1;
          else
          {
            //Console.WriteLine($"{IsPal(res)}");
            var c = res.ToString();
            var n = c.Length;
            var st = Convert.ToInt32( c.Substring(0,n/2));
            var sb = new StringBuilder();
            do
            {
              //Console.WriteLine("test");
              if(res.ToString().Length>c.Length)
              {
                //Console.WriteLine( "wei");
                c= res.ToString();
                n = c.Length;
                st = Convert.ToInt32(c.Substring(0,n/2));
              }
              if(n%2==0)
              {
                sb.Append(st.ToString());
                sb.Append(string.Join("", st.ToString().Reverse().ToArray()));
                res = Convert.ToInt32(sb.ToString()) ;
                sb.Clear();
              }
              else
              {
                for(int j=0;j<=9;j++)
                {
                  sb.Append(st.ToString());
                  sb.Append(j.ToString());
                  sb.Append(string.Join("", st.ToString().Reverse().ToArray()));
                  res = Convert.ToInt32(sb.ToString());
                  if(IsPal(res) && res>a)
                    break;
                  sb.Clear();
                }
              }
              st++;
              //Console.WriteLine($"res {res}ispal{IsPal(res)} st {st}");
            }
            while(!IsPal(res) || res<=a);

          }
          //Console.WriteLine($"res {res}");
          return res;
       }
       public bool IsPal(int a)
       {
          var c = a.ToString();
          var n = c.Length;
          var flag=true;
          for(int i=0;i<n;i++)
          {
            if(c[i]!=c[n-i-1])
            {
              flag=false;
              break;
            }
          }
          //Console.WriteLine($"{a} is {flag}");
          return flag;
       }
      public bool IsPrime(int a)
      {
        var v = Math.Sqrt(a);
        var flag=true;
        for(int i=2;i<=v;i++)
        {
          if(a%i==0)
          {
            flag=false;
            break;
          }
        }
        return flag;
      }
    }
}
