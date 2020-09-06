using System;
using System.Collections.Generic;
namespace ShortestPaths
{
    public class ShortestPath
    {
      private EdgeWeightedDiGraph graph;
      private  double [] distTo;
      private  bool [] hasPath;
      private  bool [] marked;
      private  List<DirectedEdge> [] listOfEdges;
      public ShortestPath(EdgeWeightedDiGraph graph)
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
        var verticesToCover = new Stack<int>();
        verticesToCover.Push(v);
        distTo[v]=0;
        while(verticesToCover.Count>0)
        {
          var v1 =verticesToCover.Pop();
          var adjacentEdgeList = graph.Adj(v1);
          foreach(var edge in adjacentEdgeList)
          {
            //if(marked[edge.To]) continue;
            if(distTo[edge.To]>(distTo[v1] + edge.Weight))
            {

              distTo[edge.To] = distTo[v1] +edge.Weight;
              marked[edge.To]=true;
              hasPath[edge.To]=true;
              verticesToCover.Push(edge.To);
              foreach(var item in listOfEdges[v1])
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
