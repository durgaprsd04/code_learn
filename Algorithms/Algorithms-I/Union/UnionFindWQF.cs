using System;
namespace Union
{
    public class UnionFindWQF
    {
        private  int [] array;
        private  int [] depth;
        public UnionFindWQF(int n)
        {
            array = new int[n];
            depth = new int[n];
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
                if(depth[a]<depth[b])
                {
                    depth[b]+=depth[a];
                    array[a]=b;
                }
                else
                {
                    depth[a]+=depth[b];
                    array[b]=a;
                }       
            }   
        }
        public void PrintArray()
        {
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", depth));
        }

    }
}