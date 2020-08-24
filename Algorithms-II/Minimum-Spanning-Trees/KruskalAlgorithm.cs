using Union;
using System;
namespace Minimum_Spanning_Trees
{
    class KruskalAlgorithm
    {
        Graph graph;
        public   KruskalAlgorithm(Graph graph)
        {
            this.graph= graph;
        }
        public void Run()
        {
            UnionFindWQPC uf = new UnionFindWQPC(graph.Vertices);
            var edgeList = graph.EdgeList1;
            edgeList.Sort();
            foreach(var edge in edgeList)
            {
                if(!uf.isConnected(edge.Vertice, edge.Other))
                {
                    edge.Isblack =true;
                    uf.Connect(edge.Vertice, edge.Other);
                }
            }
        }
    }
}