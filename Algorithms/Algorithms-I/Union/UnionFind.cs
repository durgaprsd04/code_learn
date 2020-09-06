using System;
namespace Union
{
    public class UnionFind
    {
        private  int [] array;
        public UnionFind(int n)
        {
            array = new int[n];
            for(int i=0;i<n;i++)
            {
                array[i]=i;
            }
        }
        public bool isConnected(int i, int j)
        {
            if(array[i]==array[j])
                return true;
            else
                return false;
        }
        public void Connect(int a, int b)
        {
            if(array[a]!=array[b])
                {
                    var b1 = array[b];
                    for(int i=0;i<array.Length; i++)
                        { 
                            if(array[i]==b1)
                            {
                                array[i]=array[a];
                            }
                        }
                }
        }
        public void PrintArray()
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}