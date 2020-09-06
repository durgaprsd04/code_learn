using System;
using System.Collections;
using System.Collections.Generic;
namespace  LeetCode
{
public class ZigZag
    {
      public string Convert(string s, int numRows) {
         if(string.IsNullOrWhiteSpace(s) || s.Length<numRows ||numRows==1)
           return s;
          var charArray = s.ToCharArray();
          var len = charArray.Length;
          var dummy=string.Empty;
          var flag=true;
          int [] keyList = new int[2*numRows-2] ;
          for(int i=0;i<numRows;i++)
            keyList[i]=((i+1)%numRows);
          int j =1;
          Console.WriteLine(string.Join(',',keyList));
          
          for(int i=numRows-1;i>1;i--)
          {
            Console.WriteLine($"{i+j} i {i}");
            keyList[numRows-1 +j]=i%numRows;
            j++;
          }
          Console.WriteLine(string.Join(',',keyList));
          Dictionary<int,List<char>> dict = new Dictionary<int,List<char>>();
          for(int i=0;i<len;i++)
          {
              var key = keyList[(i)%(2*numRows-2)];
              if(key==0)
                flag=!flag;
              if(dict.ContainsKey(key))
                dict[key].Add(charArray[i]);
              else
              {
                var l = new List<char> {charArray[i]};
                dict.Add(key, l);
              }
          }
          for(int i=1;i<numRows;i++)
          {
            dummy = dummy + string.Join("",dict[i].ToArray());
          }
          dummy = dummy + string.Join("",dict[0].ToArray());
          return dummy;
      }
    }
}
