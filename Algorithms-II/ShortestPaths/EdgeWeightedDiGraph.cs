using System;
using System.Collections.Generic;
using System.IO;
namespace ShortestPaths
{
    public class EdgeWeightedDiGraph
    {
      private Bag<DirectedEdge> [] edges;
      private readonly int verticeCount, edgeCount;
      public int VerticesCount => verticeCount;
      public int EdgesCount => edgeCount;
      public  EdgeWeightedDiGraph(string fileName)
      {
        StreamReader sr = new StreamReader(fileName);
        verticeCount = Convert.ToInt32(sr.ReadLine());
        edgeCount = Convert.ToInt32(sr.ReadLine());
        edges = new Bag<DirectedEdge> [verticeCount];
        while(sr.Peek()>-1)
        {
          var res = sr.ReadLine().Split(',');
          var edge = new DirectedEdge(Convert.ToInt32(res[0]), Convert.ToInt32(res[1]), Convert.ToDouble(res[2]));
          AddEdge(edge);
        }
      }
      public void AddEdge(DirectedEdge edge)
      {
        Console.WriteLine($"Adding edge {edge.From} "+edge);
        if(edges[edge.From]==null)
          edges[edge.From] = new Bag<DirectedEdge>(edge);
        else
          edges[edge.From].Add(edge);
      }
      public IList<DirectedEdge> Adj(int v)
      {
       if(edges[v]!=null)
          return edges[v].GetIterator();
       return new List<DirectedEdge>();
      }
      public void Print()
      {
        int i=0;
        foreach(var v in edges)
        {
           Console.WriteLine($"{i}"+ v?.ToString());
           i++;
        }
      }
    }
}
