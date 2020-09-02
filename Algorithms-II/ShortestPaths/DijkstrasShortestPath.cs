using System;
using PriorityQueues;
using System.Collections.Generic;
namespace ShortestPaths
{
    public class DijkstrasShortestPath
    {
      private EdgeWeightedDiGraph graph;
      private  double [] distTo;
      private  bool [] hasPath;
      private  bool [] marked;
      private IndexedPriorityQueue<DirectedEdge> verticesToCover;
      private  List<DirectedEdge> [] listOfEdges;
      public DijkstrasShortestPath(EdgeWeightedDiGraph graph)
      {
        this.graph = graph;
        this.listOfEdges = new List<DirectedEdge> [graph.VerticesCount];
        for(int i=0 ;i< listOfEdges.Length ;i++)
          listOfEdges[i] = new List<DirectedEdge>();

        this.distTo = new double [graph.VerticesCount];
        for(int i=0;i<distTo.Length;i++)
          distTo[i]=double.MaxValue ;
        this.hasPath = new bool [graph.VerticesCount];
        this.marked = new bool [graph.VerticesCount];
      }
      public IList<DirectedEdge> [] PathTo(int v)
      {
        verticesToCover = new IndexedPriorityQueue<DirectedEdge>(graph.VerticesCount);
        verticesToCover.Add(v, new DirectedEdge(0,0, 0.0));
        distTo[v]=0;
        while(!verticesToCover.IsEmpty())
        {
          var v1 =verticesToCover.DeleteMin();
          var adjacentEdgeList = graph.Adj(v1.Key);
          foreach(var edge in adjacentEdgeList)
          {
            //if(marked[edge.To]) continue;
            if(distTo[edge.To]>(distTo[v1.Key] + edge.Weight))
            {
              distTo[edge.To] = distTo[v1.Key] +edge.Weight;
              marked[edge.To]=true;
              hasPath[edge.To]=true;
              verticesToCover.Add(edge.To, edge);

              foreach(var item in listOfEdges[v1.Key])
                listOfEdges[edge.To].Add(item);
              if(!listOfEdges[edge.To].Contains(edge))
                listOfEdges[edge.To].Add(edge);
            }
          }
        }
        return listOfEdges;
      }
      public double DistTo(int v)
      {
        return distTo[v];
      }
      public bool HasPathTo(int v)
      {
        return hasPath[v];
      }
    }
}
