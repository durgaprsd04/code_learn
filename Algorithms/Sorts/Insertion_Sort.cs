using System;
namespace Sorts
{
    public class Insertion_Sort
    {
        private int [] _array;
        public Insertion_Sort(int [] array)
        {
            _array=array;
        }
        public void Sort()
        {
            int N = _array.Length;
            for(int i=0;i<N;i++)
            {
                for(int j =i;j>0;j--)
                {
                    if(_array[j]<_array[j-1])
                    {
                        var swap=_array[j-1];
                        _array[j-1]=_array[j];
                        _array[j]=swap;
                    }
                }
            }
        }
        public void Print()
        {
            Console.WriteLine(string.Join(",",_array));
        }
    }
}
