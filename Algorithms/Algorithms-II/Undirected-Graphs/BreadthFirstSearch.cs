using System;
using System.Collections;

namespace Undirected_Graphs
{   
    public class BreadthFirstSearch
    {
        private Graph graph;
        public bool [] marked;
        int vertices;
        public int[] edgeTo;
        public int[] distTo;
        public BreadthFirstSearch(Graph g)
        {
            this.graph =g;
            vertices = g.Vertices;
            edgeTo= new int[vertices];
            distTo = new int[vertices];
            marked = new bool[vertices];

        }
        public void Bfs()
        {    
            for(int i =0; i< vertices;i++)
            {
               Queue queue = new Queue();
               queue.Enqueue(i);
               marked[i]=true;
               while(queue.Count>0)
               {
                   var element =  Convert.ToInt32(queue.Dequeue());
                   var adjList = graph.Adj(element);
                   while(adjList.Count>0)
                   {
                       var v =  Convert.ToInt32(adjList.Dequeue());
                       if(!marked[v])
                       {
                           queue.Enqueue(v);
                           marked[v]=true;
                           edgeTo[v] = element;
                           distTo[v]=distTo[element]+1;
                       }
                   }
               }
            }
        }
        public void Print()
        {
            for(int i=0;i<vertices;i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", i, marked[i], edgeTo[i],distTo[i] );
            }
        }

    }
}
