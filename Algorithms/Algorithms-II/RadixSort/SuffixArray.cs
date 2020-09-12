using System;
using System.IO;
using System.Collections.Generic;
namespace RadixSort
{
    class SuffixArray
    {
      public string [] GetSuffixArray(string str)
      {
        List<string> strList = new List<string>();
        var len = str.Length;
        for(int i=0;i<len;i++)
        {
          strList.Add(str.Substring(i,len-i));
        }
        strList.Sort();
        return strList.ToArray();
      }
      public string LongestRepeatingSubSequence(string s)
      {
        var  suffixArray = GetSuffixArray(s);
        var len = suffixArray.Length;
        var result = string.Empty;
        for(int i=0;i<len-1;i++)
        {
            var buffer= lcs(suffixArray[i], suffixArray[i+1]);
            if(result.Length<buffer.Length)
              result = buffer;
        }
        return result;
      }
      public string lcs(string a, string b)
      {
        string s =string.Empty;
        var len = a.Length>b.Length? b.Length:a.Length;
        for(int i=0;i<len;i++)
        {
          if(a[i]==b[i])
            s=s+a[i].ToString();
        }
        return s;
      }
    }
}
