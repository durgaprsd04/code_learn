using System;
using System.Linq;
namespace PriorityQueues
{
public class MinHeap<T> where T:IComparable<T>
    {
        private T [] array;
        private int N;
        public MinHeap(T [] input,int n)
        {
            array = new T[n+1];
            N=n+1;
            array[0]=default(T);
            int i=1;
            foreach(T v in input)
            {
                if(!array.Contains(v)&& v.CompareTo(default(T))!=0)
                {
                     array[i]=v;
                     i++;
                }
            }
            N=i;
            //Console.WriteLine(string.Join(",", array));
        } 
        public void Add(T[] input, int m)
        {
            var array1 = new T[N+m+1];
            int i=1;
           foreach(T v in array){
                if(!array1.Contains(v) && v.CompareTo(default(T))!=0)
                {
                    array1[i] = v;
                    i++;
                }
                
            }
            N=i;
           foreach(T v in input)
            {
                if(!array1.Contains(v)&& v.CompareTo(default(T))!=0)
                {
                    array1[i]=v;
                    i++;
                }
            }
            m= i-N ;
            array = new T[N+m];
            i=1;
            foreach(T v in array1)
            {
                if(!array.Contains(v)&& v.CompareTo(default(T))!=0)
                {
                    array[i]=v;
                    i++;
                }                    
            }
            N= N+m;
        }
        public void Delete(T element)
        {
            for(int i=1;i<N;i++)
            {
                int j=1;
                if(array[i].CompareTo(element)==0)
                {
                    j = i+1;
                }
                if(j<N)
                    array[i]=array[j];
                else
                    array[i]=default(T);
                j++;
            }
            N=N-1;
        }
        public void Sink(int n,int limit)
        {
            int largerindex=0;
            var flag=false;
            if(2*n >=limit)
                return;
            if((2*n+1)>=limit)
            {
                if(array[2*n].CompareTo(array[n])<0)
                    {
                        largerindex=2*n;
                        swap(largerindex,n);
                        return;
                    }
                return;
            }

            if(array[2*n+1].CompareTo(array[n])<0 || array[2*n].CompareTo(array[n])<0)
            {
                
                largerindex =  (array[2*n+1].CompareTo(array[2*n])<0)?2*n+1:2*n;
                swap(largerindex, n);
                flag=true;
            }
            if(!flag)
                return;
            Sink(largerindex, limit);
        }
        public void Swim(int n)
        {
            if(array[n].CompareTo(array[n/2])<0)
            {
                swap(n/2, n);
            }
            if(n/4<1)
                return;
            Swim(n/2);
        }
        public void swap(int i, int j)
        {
            T swap = array[i];
            array[i]=array[j];
            array[j]=swap;
        }
        public void Sort()
        {
            for(int k=N/2-1;k>=1;k--)
            {
                Sink(k,N);
            }
        }
        public void Print()
        {
            Console.WriteLine(string.Join(',',array));
        }
        public T Pop()
        {
            if(N==0)
                return default(T);
            swap(N-1, 1);
            Sink(1, N-2);
            N = N-1;
            return array[N];
        }
        public bool HasElement()
        {
            if(N>1)
                return true;
            else 
                return false;
        }
    }
}
