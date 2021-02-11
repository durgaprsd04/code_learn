using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharp
{
    public class LinqTest
    {

        public int SumUpto(int n)
        {
            int sum =0;
            for(int i=1;i<=n;i++)
                sum+=i;
         
            return Enumerable.Range(1 , n).Aggregate((sum, n) => sum+n);
            //return sum;
        }
        public IEnumerable<int> GetAllInts(int n)
        {
            for(int i=0;i<n;i++)
            {
                yield return i;
            }
        }
    }
}