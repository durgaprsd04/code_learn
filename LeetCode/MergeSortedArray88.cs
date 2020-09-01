using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MergeSortedArrayClass
    {
      public void Merge(int[] nums1, int m, int[] nums2, int n)
      {
        int i=m-1,j=n-1;
        int t = m+n-1;
        int k =t;
        int [] temp = new int [m+n];
            while(i>=0&& j>=0&& k>0)
            {
              Console.WriteLine($"nums1 {nums1[i]} nums2 {nums2[j]} ");
                if(nums1[i]>nums2[j])
                  {
                    temp[k] =nums1[i];
                    i--;
                  }
                  else
                  {
                    temp[k] = nums2[j];
                    j--;
                  }
                  k--;
                //Console.WriteLine(string.Join(',', temp));
            }
            if(i>=0)
              while(i>=0)
                  temp[k--]=nums1[i--];
            if(j>=0)
              while(j>=0)
                  temp[k--] = nums2[j--];
            for(i=0;i<(m+n);i++)
            {
              nums1[i] = temp[i];
            }
      }
    }
}
