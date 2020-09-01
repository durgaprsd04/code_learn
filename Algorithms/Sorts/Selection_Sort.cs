using System;
namespace Sorts
{
    public class Selection_Sort
    {
        private int [] _array;
        public Selection_Sort(int [] array)
        {
            _array=array;
        }
        public void Sort()
        {
            int N = _array.Length;
            for(int i=0;i<N;i++)
            {
                for(int j =i+1;j<N;j++)
                {
                    if(_array[i]>_array[j])
                    {
                        var swap=_array[i];
                        _array[i]=_array[j];
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
