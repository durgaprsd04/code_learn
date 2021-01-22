using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class AllSubSets
    {
        public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
          IList<IList<int>> tempResult = new List<IList<int>>();
            IList<IList<int>> newTempResult = new List<IList<int>>();
            HashSet<string> hs = new HashSet<string>();

        var l1 = new List<int>();
        result.Add(new List<int>(l1));
        foreach(var n in nums)
        {
            l1.Add(n);
            tempResult.Add(new List<int>(l1));
            l1.Clear();
        }
        while(tempResult.Count>0)
        {
            foreach(var list in tempResult)
            {
                Console.WriteLine("tempresult "+string.Join(",",list));
                foreach(var n in nums)
                {

                    if(!list.Contains(n)&&!hs.Contains(GetSortedHash(list,n)))
                    {
                        var newList = new List<int>(list.ToArray());
                        newList.Add(n);
                        newTempResult.Add(newList);
                        hs.Add(GetSortedHash(list,n));
                    }
                }
                  
            }
            foreach(var smallRes in tempResult)
            {
                result.Add(smallRes);
            }
        tempResult = new List<IList<int>>();
        foreach(var l in newTempResult)
        {
            tempResult.Add(new List<int>(l.ToArray()));
        }
        newTempResult=new List<IList<int>>();
        hs.Clear();
        }
        return result;
    }
    public string GetSortedHash(IList<int> l, int n)
    {
        var r = new List<int>(l);
        r.Add(n);
        r.Sort();
        return string.Join("",r.ToArray());
    }
    }
}