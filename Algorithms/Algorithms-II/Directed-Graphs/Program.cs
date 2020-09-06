using System;
using System.IO;
using System.Linq;

namespace Directed_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading tinyG.txt!");
            StreamReader sr = new StreamReader("tinyG2.txt");
            var vertices = Convert.ToInt32(sr.ReadLine());
            var edges = Convert.ToInt32(sr.ReadLine());
            DirectedGraph g = new DirectedGraph(vertices);
            for(int i=0;i<edges;i++)
            {
                var w = sr.ReadLine().Split('-').Select(x=> Convert.ToInt32(x)).ToArray();
                g.AddEdge(w[0], w[1]);
            }
            g.Print();

            /*
            var rv = g.Reverse();
            Console.WriteLine("reverse printing");
            rv.Print();
            */
            /*
            Reachability reach = new Reachability();
            var v1=0;
            var v2=4;
            var result = reach.Reachable(g,v1,v2);
            Console.WriteLine($"{v1} & {v2} are reachable "+result);
            */
            
            StrongComponents sc = new StrongComponents(g);
            sc.Kosharaju_Sharir();
            
            /*
            DepthFirstSearch depthFirstSearch = new DepthFirstSearch(g);
            depthFirstSearch.DFS();
            depthFirstSearch.Print();
            */
            /*
            BreadthFirstSearch bfs = new BreadthFirstSearch(g);
            bfs.Bfs();
            bfs.Print();
            */
           /*
            TopologicalSort ts = new TopologicalSort(g);
            var postorder = ts.TopologicalSorting();
            Console.WriteLine("Post Order  "+string.Join(',',postorder.ToArray()));
            Console.WriteLine("Pre Order  "+string.Join(',',ts.Dfs.PreOrder.ToArray()));
            Console.WriteLine("Reverse  PostOrder  "+string.Join(',',ts.Dfs.ReversePostOrder.ToArray()));
           */
        }
    }
}
