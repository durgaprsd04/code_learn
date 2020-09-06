using System;
namespace Sorts
{
    public class Shell_Sort
    {
        private int [] _array;
        private int h, N;
        public Shell_Sort(int [] array)
        {
            _array=array;
            N = _array.Length;
           // h = (N-1)/3;
        }
        public void Sort()
        {
            while(h<N/3) h= 3*h+1;
            while(h>=1)
            {
                for(int i=h;i<N;i++)
                {
                    for(int j =i;j>=h;j=j-h)
                    {
                        if(_array[j]<_array[j-h])
                        {
                            var swap=_array[j-h];
                            _array[j-h]=_array[j];
                            _array[j]=swap;
                        }
                    }
                }
                Console.WriteLine("H for this iteration "+h);
                Print();
                h=h/3;
            }
        }
        public void Print()
        {
            Console.WriteLine(string.Join(",",_array));
        } 
    }
}