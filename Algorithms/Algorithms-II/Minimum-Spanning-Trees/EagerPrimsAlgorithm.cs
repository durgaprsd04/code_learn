using System.Linq;
using System.Collections.Generic;
using PriorityQueues;
using System;
namespace Minimum_Spanning_Trees
{
    class EagerPrimsAlgorithm
    {

        IndexedPriorityQueue<Edge>  minHeap ;
        List<Edge> listOfEdges;
        int [] EdgeTo;
        double [] distTo;
        bool [] isVisited;
        Graph graph;
        int vertices;

        public EagerPrimsAlgorithm(Graph graph)
        {
            this.graph = graph;
            this.vertices = graph.Vertices;
            EdgeTo = new int [vertices];
            distTo = new double [vertices];
            isVisited = new bool [vertices];
            for(int i=0;i<distTo.Length;i++)
            {
               distTo[i]=Double.MaxValue;
            }
            distTo[0]=0;
            minHeap = new IndexedPriorityQueue<Edge>(vertices);
            listOfEdges =  new List<Edge>();
        }
        public void Run()
        {
            //var iterator = graph.GetIterator(0).GetIterator().ToArray().Select(x => x as Edge).ToList();
            //iterator.Sort();
            var first =  new Edge(0,0,0);
            minHeap.Add(0,first);
            while(!minHeap.IsEmpty())
            {
              var min = minHeap.DeleteMin();
              Console.WriteLine("Adding edge "+min);
              listOfEdges.Add(min.Value);
              Run(min.Key);
            }
            foreach(var edge in listOfEdges)
              Console.Write(edge+" > ");
        }
        public void Run(int v)
        {
            isVisited[v]=true;
            var listOfEdges = graph.GetIterator(v).GetIterator().ToArray().Select(x => x as Edge).ToArray();
            Console.WriteLine("List of adj vertices "+ string.Join<Edge>(',' ,listOfEdges));
            foreach(var edge in listOfEdges)
            {
              //due to issues in grpah implementation if vertex is the sam eother edge would be vertex.
              var w = (edge.Other==v)?edge.Vertice:edge.Other;
              ///Console.WriteLine($"v {v} w {w} distTo[w]{distTo[w]} edge.Weight {edge.Weight} edge{edge}");
              if(isVisited[w])continue;
              if(edge.Weight<=distTo[w])
              {
                  Console.WriteLine($"v {v} w {w} distTo[w]{distTo[w]} edge.Weight {edge.Weight} edge{edge}");
                  distTo[w] = edge.Weight;
                  minHeap.Add(w, edge);
              }
            }
        }
    }
}
