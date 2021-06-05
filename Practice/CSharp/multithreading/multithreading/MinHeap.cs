using System;
using System.Linq;
using System.Collections.Generic;
namespace multithreading.interfaces
{
    public class MinHeap<T> where  T:IComparable<T>
    {
        private List<T> minHeap;
        public MinHeap()
        {
            minHeap = new List<T>();
        }
        public void Add(T element)
        {   
            minHeap.Add(element);
            minHeap.Sort();
        }
        public T RemoveMin(bool flag)
        {
            var min = minHeap.Min();
            var index=-1;
            for(int i=0;i<minHeap.Count();i++)
            {
                if(minHeap[i].CompareTo(min)==0)
                {
                    index = i;
                    break;
                }
            }
            if(flag)
            {
                minHeap.RemoveAt(index);
                minHeap.Sort();
            }
            return min;
        }
        public List<T> GetList()
        {
            return minHeap;
        }
        public void Clear()
        {
            minHeap.Clear();
        }

    }
}