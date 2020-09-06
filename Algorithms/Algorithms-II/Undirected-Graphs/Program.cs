using System;
using System.IO;
using System.Linq;

namespace Undirected_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading tinyG.txt!");
            StreamReader sr = new StreamReader("tinyG.txt");
            var vertices = Convert.ToInt32(sr.ReadLine());
            var edges = Convert.ToInt32(sr.ReadLine());
            Graph g = new Graph(vertices);
            for(int i=0;i<edges;i++)
            {
                var w = sr.ReadLine().Split('-').Select(x=> Convert.ToInt32(x)).ToArray();
                g.AddEdge(w[0], w[1]);
            }
            g.Print();
           // DepthFirstSearch df = new DepthFirstSearch(g);
            //df.DFS();
           // df.Print();
           // BreadthFirstSearch bf = new BreadthFirstSearch(g);
          //  bf.Bfs();
          //  bf.Print();
          ConnectedComponents cc = new ConnectedComponents(g);
          cc.ConnectedComponentsQuery();
          cc.Print();

           /*
            Bag<int> t = new Bag<int>(3);
            t.Add(4);
            t.Add(5);
            t.Print();
            */
        }
    }
}
