using System.Collections;
using System;
namespace Directed_Graphs
{
    public class DirectedGraph  
    {
        private Bag<int> [] vertices ;
        private int size;
        
        private DirectedGraph reverseGraph;

        public DirectedGraph(int size )
        {
            this.size = size;
            vertices = new Bag<int>[size];
            for(int i=0; i<vertices.Length;i++)
            {
                vertices[i] = new Bag<int>(i);
            }
        }
        public DirectedGraph Reverse()
        {
            reverseGraph = new DirectedGraph(size);
            for(int i=0;i<size;i++)
            {
                var c = Adj(i);
                while(c.Count>0)
                {
                    var d= (int)c.Dequeue();
                    reverseGraph.AddEdge(d, i);
                }
            }
            return reverseGraph;
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