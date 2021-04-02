using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class KthSmallestClass
    {

        public int KthSmallest(int[][] matrix, int k)
        {
            List<int> sortedList = new List<int>();
            HashSet<Tuple<int, int>> hs = new HashSet<Tuple<int, int>>();
            var m = matrix.Count();
            var n = matrix.FirstOrDefault().ToArray().Count();
            // int i=0;
            //int j=0;
            //var target =0;
            //var next=0
            //sortedList.Sort()
            Console.WriteLine(string.Join(",", hs.ToArray().Select(x => x.ToString())));
            Console.WriteLine(string.Join(",", sortedList.ToArray()));
            return sortedList[k];
        }
    }
}