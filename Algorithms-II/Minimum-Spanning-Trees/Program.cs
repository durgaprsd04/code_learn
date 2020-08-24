using System;
using System.IO;

namespace Minimum_Spanning_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading tinyG4.txt");
            StreamReader sr = new StreamReader("tinyG4.txt");
            var vertices = Convert.ToInt32(sr.ReadLine());
            var edges = Convert.ToInt32(sr.ReadLine());
            Graph graph =new Graph(vertices, edges);
            for(int i=0;i<edges;i++)
            {
                var v  =sr.ReadLine().Split('-');
                var vertice1= Convert.ToInt32(v[0]);
                var vertice2 = Convert.ToInt32(v[1]);
                var weight = Convert.ToDouble(v[2]);
                graph.AddEdge(weight, vertice1, vertice2);
            }
            Console.WriteLine("Graph created");
            graph.Print();
            graph.PrintEdgeList();
            KruskalAlgorithm ka = new KruskalAlgorithm(graph);
            ka.Run();
            Console.WriteLine("-------------------------");
            graph.PrintEdgeList(true);
             Console.WriteLine("MST Path sum {0}",graph.MSTSum());
             LazyPrimsAlgorithm lz = new LazyPrimsAlgorithm(graph);
             lz.Run();
        }
    }
}
