using System;

namespace Undirected_Graphs
{   
    public class ConnectedComponents
    {
        private Graph graph;
        private DepthFirstSearch depthFirstSearch;
        private int Vertices;
        public int [] connected;
        
        
        public ConnectedComponents(Graph graph)
        {
            this.graph=graph;
            connected =new int[graph.Vertices];
            depthFirstSearch = new DepthFirstSearch(graph);
            this.Vertices = graph.Vertices;
        }
        public void ConnectedComponentsQuery()
        {
            var count =0;
            for(int i=0;i< Vertices;i++)
            {
                connected[i]=count;
                if(!depthFirstSearch.isVisited[i]) 
                {
                    depthFirstSearch.isVisited[i]=true;
                    depthFirstSearch.edgeTo[i]=-1;
                    count++;
                    connected[i]=count;
                    depthFirstSearch.Dfs(i);                   
                }
                    
            }
        }
         public void Print()
        {
           var vertices = graph.Vertices;
           for(int i=0;i<vertices;i++)
           {
               Console.WriteLine("{0} {1} {2} {3}", i, depthFirstSearch.isVisited[i], depthFirstSearch.edgeTo[i], connected[i]);
           }
        }

    }
}
