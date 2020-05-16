using System.Collections;
using System;
namespace Directed_Graphs
{
    public class DirectedGraph  
    {
        private Bag<int> [] vertices ;
        private int size;

        public DirectedGraph(int size )
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
           // only one direction;
            vertices[u].Add(w);
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