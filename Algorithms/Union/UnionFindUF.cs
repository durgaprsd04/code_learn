using System;
namespace Union
{
    public class UnionFindUF
    {
        private  int [] array;
         private  int [] depth;
        public UnionFindUF(int n)
        {
            array = new int[n];
            depth = new int [n];
            for(int i=0;i<n;i++)
            {
                array[i]=i;
                depth[i]=1;
            }
        }
        public bool isConnected(int i, int j)
        {
            if(root(i)==root(j))
                return true;
            else
                return false;
        }
        public int root(int i)
        {
            while(array[i]!=i)
                i=array[i];
            return i;
        }
        public void Connect(int i, int j)
        {
            var a = root(i);
            var b = root(j);
            if(a!=b)
            {
                array[b]=a;
                depth[b]++;
            }
        }
        public void PrintArray()
        {
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", depth));
        }
    }
}