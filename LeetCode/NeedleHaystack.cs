using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class  NeedleHaystack
    {
        public int StrStr(string haystack, string needle)
        {
            if(string.IsNullOrWhiteSpace(haystack))
              return -1;
            if(string.IsNullOrWhiteSpace(needle))
              return 0;
            if(needle.Length>haystack.Length)
              return  -1;
             var needleArray = needle.ToCharArray();
             var isDetected=false;
             var count=0;
             var pos=0;
             foreach(char c in haystack)
             {

                 //Console.WriteLine(c);
                  if(c==needleArray[0])
                  {
                    if(count+needle.Length<=haystack.Length)
                    {
                      //Console.WriteLine("Substring "+haystack.Substring(count, needle.Length));
                      if(haystack.Substring(count, needle.Length)==needle)
                      {
                        isDetected=true;
                        pos=count;
                        break;
                      }
                   }
                }
                  count++;
            }
            if(isDetected)
              return pos;
            else
              return -1;
        }
    }
}
