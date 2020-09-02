using System;

namespace ShortestPaths
{
  public class DirectedEdge : IComparable<DirectedEdge>
    {
      private readonly double weight;
      private readonly int to;
      private readonly int from1;
      public DirectedEdge(int from1,int to, double weight)
      {
        this.to=to;
        this.from1 = from1;
        this.weight = weight;
      }
      public override string ToString() => $"[{from1}->{to}]({weight})";
      public int From =>from1;
      public int To => to;
      public double Weight => weight;
      public int CompareTo(DirectedEdge e)
      {
            if(e==null)
                return -1;
            return (int )(100*(this.Weight -  e.weight)) ;
      }
      public int CompareTo(object obj)
      {
        if(obj==null)
          return -1;
        var e = obj as DirectedEdge;
        return (int)(100*(this.weight - e.weight)) ;
      }
    }
}
