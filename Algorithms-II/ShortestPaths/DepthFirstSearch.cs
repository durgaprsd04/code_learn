using System;
using System.Collections.Generic;
namespace ShortestPaths
{
    public class DepthFirstSearch
    {
      private EdgeWeightedDiGraph graph;
      private  bool [] isMarked;
      private  Queue<int> postOrder = new Queue<int>();
      public  Queue<int> PostOrder => postOrder;
      public DepthFirstSearch(EdgeWeightedDiGraph graph)
      {
        this.graph = graph;
        isMarked  = new bool[graph.VerticesCount];
      }
      public void Dfs()
      {
        for(int i=0;i<graph.VerticesCount;i++)
        {
          if(!isMarked[i])
          {
            isMarked[i]=true;
            Dfs(i);
            postOrder.Enqueue(i);
          }
        }
      }
      public void Dfs(int i)
      {
        var adjEdges = graph.Adj(i);
        foreach(var edge in adjEdges)
        {
          //Console.WriteLine(string.Join(',', isMarked));
          if(!isMarked[edge.To])
          {
            isMarked[edge.To]=true;
            Dfs(edge.To);
            postOrder.Enqueue(edge.To);
          }
        }
      }
    }
}
