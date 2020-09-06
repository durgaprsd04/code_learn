using System;
using System.Collections.Generic;

namespace Minimum_Spanning_Trees
{
    public class Edge : IComparable<Edge>
    {
        double weight;
        int vertice;
        int other;
        bool isblack;

        public bool Isblack { get => isblack; set => isblack = value; }
        public int Vertice { get => vertice; set => vertice = value; }
        public int Other { get => other; set => other = value; }
        public double Weight { get => weight; set => weight = value; }

        public Edge(double weight, int vertice, int other)
        {
            this.Weight = weight;
            this.Vertice= vertice;
            this.Other = other;
        }
        public override string ToString()
        {
            return string.Format("[{0}->{1}]({2} black -{3})",vertice, Other, Weight,isblack);
        }

        public int CompareTo(Edge e)
        {
            if(e==null)
                return (int)(100*this.weight);
            return (int)(100*(this.Weight - e.Weight));
        }

        public int CompareTo(object obj)
        {
             if(obj==null)
                return (int)(100*this.weight);
            var e = obj as Edge;
           return (int)(100*(this.Weight - e.Weight));
        }
    }
    public class Graph
    {
        Bag<Edge> []  edges ;
        List<Edge> EdgeList = new List<Edge>();
        int vertices,edgeCount;
        bool [] marked;
        public Graph(int vertices, int edgeCount)
        {
            this.Vertices= vertices;
            this.edgeCount= edgeCount;
            edges = new Bag<Edge>[vertices];
            marked  = new bool[vertices];
        }

        public int Vertices { get => vertices; set => vertices = value; }
        public List<Edge> EdgeList1 { get => EdgeList; set => EdgeList = value; }

        public void AddEdge(double weight, int to, int from)
        {
            var edge = new Edge(weight, to, from);
            EdgeList1.Add(edge);
            if(edges[to]==null)
                edges[to]= new Bag<Edge>(edge);
            else
                edges[to].Add(edge);
            if(edges[from]==null)
                edges[from]= new Bag<Edge>(edge);
            else
                edges[from].Add(edge);
        }
        public void Print()
        {
            for(int i =0;i<Vertices;i++)
            {
              if(edges[i]!=null)
              {
                  Console.Write("[{0}]",i);
                  edges[i].Print();
              }
             else
                Console.WriteLine("[{0}]",i);
            }
        }
        public void PrintEdgeList(bool checkFlag=false)
        {
            EdgeList1.Sort();
            foreach(var edge in EdgeList1)
            {
                if(checkFlag )
                {
                    if(edge.Isblack )
                    Console.WriteLine(edge.ToString());
                }
                else
                {
                     Console.WriteLine(edge.ToString());
                }
            }
        }
        public Bag<Edge> GetIterator(int to)
        {
            return edges[to];
        }
        public double MSTSum()
        {
            var sum=0.0;
            foreach(var edge in EdgeList1)
            {
             if(edge.Isblack )
                   sum+=edge.Weight;
            }
            return sum;
        }
    }
}
