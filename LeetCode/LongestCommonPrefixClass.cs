using System;
using System.Linq;

namespace LeetCode
{
  public class LongestCommonPrefixClass
  {
      public string LongestCommonPrefix(string[] strs) {
       if(strs.Length==0)
          return string.Empty;
       var first = strs[0];
       var longest ="";
       var allTest=true;
       for(int j=1;j<=first.Length;j++){
         var str = first.Substring(0,j);
         for(int i=1;i<strs.Length;i++)
          {
            if(j<=strs[i].Length)
            {
              if(!(strs[i].Substring(0, j)==str))
              {
                allTest=false;
                break;
              }
            }
            else
            {
              allTest=false;
            }
          }
         if(allTest)
         {
          longest=str;
          allTest=true;
         }
       }
       return longest;
    }
  }

}
