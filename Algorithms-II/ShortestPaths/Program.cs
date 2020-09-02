using System;

namespace ShortestPaths
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EdgeWeightedDiGraph ewdg = new EdgeWeightedDiGraph("tinyG.txt");
            ewdg.Print();
            EdgeWeightedDiGraph ewdag = new EdgeWeightedDiGraph("tinyEWDAG.txt");
            ewdag.Print();
            DepthFirstSearch dfs = new DepthFirstSearch(ewdag);
            dfs.Dfs();
            var result = dfs.PostOrder;
            Console.WriteLine("PostOrder of the dfs is "+string.Join(',', result.ToArray()));
            /*
            ShortestPath sp = new ShortestPath(ewdg);
            DijkstrasShortestPath dsp = new DijkstrasShortestPath(ewdg);
            var v =0;
            var result  = dsp.PathTo(v);
            for(int i=0;i< result.Length;i++)
            {
              Console.WriteLine($"{i}-> " + string.Join(',',result[i]));
            }
            for(int i=0;i<result.Length;i++)
            {
              Console.WriteLine($"Vertex {i} haspath {dsp.HasPathTo(i)} to {v}  with {dsp.DistTo(i)} ");
            }
            var result  = sp.PathTo(v);
            for(int i=0;i< result.Length;i++)
            {
              Console.WriteLine($"{i}-> " + string.Join(',',result[i]));
            }
            for(int i=0;i<result.Length;i++)
            {
              Console.WriteLine($"Vertex {i} haspath {sp.HasPathTo(i)} to {v}  with {sp.DistTo(i)} ");
            }
            */

        }
    }
}
