using System;
/*Heap sort uses a max heap which pushes out max all the time. Array implementation of heap sort. */
/*Possible bug on the first few lines of the code. */
namespace Sorts
{
    public class Heap
    {
        private char [] array;
        private int N;
        public Heap(char [] input,int n)
        {
            array = new char[n+1];
            N=n+1;
            array[0]='#';
            for(int i=1;i<=n;i++)
            {
                array[i]=input[i-1];
                //Console.WriteLine(array[i]);
            }
            Console.WriteLine(string.Join(",", array));
        } 
        public void Sink(int n,int limit)
        {
            int largerindex=0;
            var flag=false;
            if(2*n >=limit)
                return;
            if((2*n+1)>=limit)
            {
                if(array[2*n]>array[n])
                    {
                        largerindex=2*n;
                        swap(largerindex,n);
                        return;
                    }
            }

            if(array[2*n+1]>array[n] || array[2*n]> array[n])
            {
                
                largerindex =  (array[2*n+1]>array[2*n])?2*n+1:2*n;
                swap(largerindex, n);
                //Console.WriteLine(array[largerindex]+""+array[n]);
                flag=true;
            }
            //Console.WriteLine("herel {0}, {1},{2}",n,N,largerindex );
            //Console.ReadKey();
            if(!flag)
                return;
            Sink(largerindex, limit);
        }
        public void Swim(int n)
        {
            //Console.WriteLine("{0} {1}", array[n],array[n/2]);
            if((int)array[n]>(int)array[n/2] )
            {
                //Console.WriteLine("inside");
                swap(n/2, n);
            }
            if(n/4<1)
                return;
            Swim(n/2);
        }
        public void swap(int i, int j)
        {
            char swap = array[i];
            array[i]=array[j];
            array[j]=swap;
        }
        public void Sort()
        {
            for(int k=N/2-1;k>=1;k--)
            {       
                Sink(k,N);
                Console.WriteLine("after swim and sink "+string.Join(",", array));
            }
            Console.WriteLine("after swim and sink "+string.Join(",", array));
            for(int i=1;i<=N-1;i++)
            {
                //Console.WriteLine("before {0}th sink "+string.Join(",", array), i);
                swap(N-i,1);
                Console.WriteLine("after swap "+string.Join(",", array));
                ///Console.ReadKey();
                Sink(1,N-i);
                //N=N-1;
                Console.WriteLine("after sink"+string.Join(",", array));
            }
        }
    }
}