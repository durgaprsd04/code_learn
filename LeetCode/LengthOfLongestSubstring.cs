using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
namespace LeetCode
{
  public class Solution2  {
    private static Dictionary<string,bool> charMapMain = new Dictionary<string,bool>();
    public int LengthOfLongestSubstring(string s)
    {
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
        var len = s.Length;
        var maxString = string.Empty;
        for(int i=0;i<len;i++)
        {
          //stopWatch.Start();
          for(int j=1;j<=len-i;j++)
          {
            //Console.WriteLine(j);
            var str = s.Substring(i,j);
            //Console.WriteLine(str+"s");
            
            if(isUnique(str))
                {
                  if(str.Length>maxString.Length)
                      maxString = str;
                }
          }
          //charMap.Clear();
       //stopWatch.Stop();
       //Console.WriteLine($"time taken for {i} :"+stopWatch.ElapsedMilliseconds);
        }
       stopWatch.Stop();
       Console.WriteLine("time taken "+stopWatch.ElapsedMilliseconds);
       Console.WriteLine(maxString);
          return maxString.Length;
    }
    public  bool isUnique(string s)
    {
      if(s.Length>2)
      if(charMapMain.ContainsKey(s.Substring(0, s.Length-2)))
        {
          Console.WriteLine(s.Substring(s.Length-2,1));
         var s1= Convert.ToChar(s.Substring(s.Length-2,1));
         return !s.Contains(s1);
        }
      var charMap = new Dictionary<char,int>();
       //Stopwatch sw = new Stopwatch();
      //sw.Start();
      foreach(char c in s)
      {
      if(charMap.ContainsKey(c))
      {
        charMap[c]++;
        break;
      }
      else
        charMap.Add(c,1);
      }
      //sw.Stop();
      //Console.WriteLine("time in isunique "+ DateTime.Now);
      var count = charMap.Values.Count(x=> x!=1);
      var result =false;
      if(count==0)
        result= true;
      else
        result=false;
      charMapMain.Add(s, result);
      return result;
    }
  }
}/*
sliding windows
    public int lengthOfLongestSubstring(String s) {
        int n = s.length();
        Set<Character> set = new HashSet<>();
        int ans = 0, i = 0, j = 0;
        while (i < n && j < n) {
            // try to extend the range [i, j]
            if (!set.contains(s.charAt(j))){
                set.add(s.charAt(j++));
                ans = Math.max(ans, j - i);
            }
            else {
                set.remove(s.charAt(i++));
            }
        }
//sliding windows optimized
        return ans;
public class Solution {
    public int lengthOfLongestSubstring(String s) {
        int n = s.length(), ans = 0;
        Map<Character, Integer> map = new HashMap<>(); // current index of character
        // try to extend the range [i, j]
        for (int j = 0, i = 0; j < n; j++) {
            if (map.containsKey(s.charAt(j))) {
                i = Math.max(map.get(s.charAt(j)), i);
            }
            ans = Math.max(ans, j - i + 1);
            map.put(s.charAt(j), j + 1);
        }
        return ans;
    }
}

*/
