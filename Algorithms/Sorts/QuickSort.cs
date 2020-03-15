using System;
namespace Sorts
{
    class QuickSort
    {
        public void Sort(int [] a){
            int lo=0;
            int hi=a.Length-1;
            Console.WriteLine(hi);
            Sort(a, lo,hi);
        }
        public void Sort(int [] a,int  lo, int hi)
        {
            if(lo+1>=hi )
                return;
            int mid = Partition(a, lo,hi);
            //Console.WriteLine(mid);
            Console.WriteLine("A after 1st:"+ string.Join(",",a));
            Sort(a,lo, mid);
            Sort(a,mid+1,hi);
        }
        public int Partition(int [] a, int lo, int hi)
        {
            //shuffled array no need to shuffle again.
            // asuming k is in lo
            int i=0, j=0, K=0,swap;
            K=a[lo];
            var len =  a.Length;
            Console.WriteLine("hi {0} lo {1}",hi,lo);
            while(i<=j)
            {
                i=lo+1;
                while(a[i]<K && i<hi) ++i; 
                j=hi;
                //reduntant to add this condition partition element will stop this

                while(a[j]>=K && j>lo)--j;
                if(i<j)
                {
                swap =a[i];
                a[i]=a[j];
                a[j]=swap;
                Console.WriteLine("A :"+ string.Join(",",a));
                }
            }
                swap =a[j];
                a[j]=a[lo];
                a[lo]=swap;
            return j;
        }
    }
}