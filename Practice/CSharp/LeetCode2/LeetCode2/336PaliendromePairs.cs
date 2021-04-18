using System.Collections.Generic;

namespace LeetCode2
{
    public class PaliendromePairs{
public IList<IList<int>> PalindromePairs(string[] words) {
     
        var len =words.Length;
        IList<IList<int>> l = new List<IList<int>>();
        
        
        HashSet<string> hs = new HashSet<string>();
        List<string> list = new List<string>();
        
        for(int i=0;i<len-1;i++)
        {
            hs.Add(words[i]);
        }
        
        /*for(int i=0;i<len;i++)
        {
            for(int j=i+1;j<len;j++)
            {
                if(IsPal(words[i] +words[j]))
                    l.Add(new List<int>(){i,j});
                
                if(IsPal(words[j]+ words[i]))
                    l.Add(new List<int>(){j,i});
            }
        }*/
        return l;
    }
    public bool IsPal(string s)
    {
        var flag =true;
        for(int i=0;i<s.Length/2;i++)
        {
            if(s[i]!=s[s.Length-i-1])
            {
                flag=false;
                break;
            }
        }
        return flag;
    }
}
}