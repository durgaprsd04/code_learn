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
            StreamReader sr = new StreamReader("tinyG.txt");
            var vertices = Convert.ToInt32(sr.ReadLine());
            var edges = Convert.ToInt32(sr.ReadLine());
            DirectedGraph g = new DirectedGraph(vertices);
            for(int i=0;i<edges;i++)
            {
                var w = sr.ReadLine().Split('-').Select(x=> Convert.ToInt32(x)).ToArray();
                g.AddEdge(w[0], w[1]);
            }
            g.Print();
            //DepthFirstSearch depthFirstSearch = new DepthFirstSearch(g);
           //depthFirstSearch.DFS();
            //depthFirstSearch.Print();
            //BreadthFirstSearch bfs = new BreadthFirstSearch(g);
          //  bfs.Bfs();
           // bfs.Print();
           TopologicalSort ts = new TopologicalSort(g);
           var postorder = ts.TopologicalSorting();
           Console.Write("Post Order  ");
           Console.WriteLine(string.Join(',',postorder.ToArray()));
        }
    }
}
