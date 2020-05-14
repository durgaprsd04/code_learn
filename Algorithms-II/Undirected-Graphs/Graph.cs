using System.Collections;
using System;
namespace Undirected_Graphs
{
    public class Graph  
    {
        private Bag<int> [] vertices ;
        private int size;

        public Graph(int size )
        {
            this.size = size;
            vertices = new Bag<int>[size];
            for(int i=0; i<vertices.Length;i++)
            {
                vertices[i] = new Bag<int>(i);
            }
        }
        public void AddEdge(int u, int w)
        {
           // Console.WriteLine("vertices added {0},{1} ",u,w);
            vertices[u].Add(w);
            vertices[w].Add(u);

        }
        public Queue Adj(int v )
        {
            var v1= vertices[v].GetIterator();
            v1.Dequeue();
            return v1;
        }
        public  int Vertices{
            get{ return size;}
        }
        public void Print()
        {
            foreach(var v in vertices)
            {
                v.Print();
            }
        }
        
    }
    
}