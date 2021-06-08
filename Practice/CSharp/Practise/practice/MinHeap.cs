using  System;
namespace Practise
{
    public class MinHeap<T> where T:IComparable<T>
    {
        private T []  heap = new T[2];
        private int N =0;
        public void Add(T element)
        {
            if(N+1>=heap.Length)
            {
                var temp = new T[heap.Length];
                Array.Copy(heap, temp, heap.Length);
                heap = new T[2*heap.Length];
                Array.Copy(temp, heap, temp.Length);

            }
            heap[++N]=element;
            Source(N);
        }
        private void Source(int index)
        {
            while(index!=1)
            {
                if(heap[index/2].CompareTo(heap[index])>0)
                {
                  Swap(index/2, index);
                }
                index = index/2;
            }
        }
        private void Sink(int index)
        {
            while(2*index< heap.Length && 2*index+1 < heap.Length)
            {   
                var minIndex = (heap[2*index].CompareTo(heap[2*index+1])>0)?2*index: 2*index+1;
                Swap(minIndex, index);
                index = minIndex;
            }
        }
        public T GetMin()
        {
            if(N==1)
                return heap[N];
            Swap(1, N);
            var result =  heap[N--];
            Sink(1);
            return result;
        }
        private void Swap(int p, int q)
        {
            var swap = heap[p];
            heap[p] = heap[q];
            heap[q] =swap;
        }
    }
}