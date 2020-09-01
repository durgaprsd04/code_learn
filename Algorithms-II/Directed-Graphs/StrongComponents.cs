//Kosharaju-Sharir Algorithm
using System;
using System.Collections;
using System.Linq;
namespace Directed_Graphs
{
    public class StrongComponents
    {
        DirectedGraph graph, reverseGraph;
        DepthFirstSearch dfs ;
        int [] cc;
        public StrongComponents(DirectedGraph graph)
        {
            this.graph = graph;
            this.reverseGraph = graph.Reverse();
            dfs = new DepthFirstSearch(graph);
            cc = new int [graph.Vertices];
        }
        public void Kosharaju_Sharir()
        {
            TopologicalSort ts = new TopologicalSort(reverseGraph);
            var postOrder = ts.TopologicalSorting();
            Stack st = ts.Dfs.ReversePostOrder;
            var count=0;
            Console.WriteLine(string.Join(',',st.ToArray().Select(x=> (int)x)));
            //dfs.DFS();
            while(st.Count>0)
            {
                var i =(int) st.Pop();
                if(dfs.isVisited[i])
                {
                    Console.WriteLine("peeking "+i);
                   // postOrder.Dequeue();
                    cc[i]=count;
                }
                else
                {
                     dfs.Dfs(i);
                    cc[i]= count++;
                }
            }
            for(int i =0;i<cc.Length;i++)
            {
                Console.WriteLine("Connected component {0} {1} ",i, cc[i]);
            }
        }
    }
}
