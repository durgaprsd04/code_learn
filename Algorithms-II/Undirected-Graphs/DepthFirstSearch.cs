using System;

namespace Undirected_Graphs
{   
    public class DepthFirstSearch
    {
        private Graph graph;
        public bool [] isVisited;
        public int[] edgeTo;
        public int [] connected;
        public DepthFirstSearch(Graph graph)
        {
            this.graph=graph;
            isVisited = new bool [graph.Vertices];
            edgeTo = new int[graph.Vertices];
            connected =new int[graph.Vertices];
        }
        public void DFS()
        {
            int v =graph.Vertices;
            for(int i=0;i<v;i++)
            {   
                if(!isVisited[i]) 
                {
                    isVisited[i]=true;
                    edgeTo[i]=-1;
                    Dfs(i);   
                }
                   
            }
        }
        public void Dfs(int i )
        {
            var adj = graph.Adj(i);
            while(adj.Count>0)
            {
                int vertice= Convert.ToInt32( adj.Dequeue());
                if(!isVisited[vertice])
                {
                    edgeTo[vertice]=i;
                    isVisited[vertice]=true;
                    Dfs(vertice);

                }
            }
        }

        internal void Print()
        {
           var vertices = graph.Vertices;
           for(int i=0;i<vertices;i++)
           {
               Console.WriteLine("{0} {1} {2} {3}", i, isVisited[i], edgeTo[i], connected[i]);
           }
        }
    }
}
