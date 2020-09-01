using System;
using System.Collections;

namespace Directed_Graphs
{   
    public class TopologicalSort
    {
        Queue postorder = new Queue();
        DirectedGraph graph;
        public DepthFirstSearch Dfs;
        int vertices;
        public TopologicalSort(DirectedGraph graph )
        {
            this.graph = graph;
            vertices = graph.Vertices;
            Dfs = new DepthFirstSearch(graph);
        }
        public Queue TopologicalSorting()
        {
            Dfs.DFS();
            return Dfs.PostOrder;
        }
    }
}
