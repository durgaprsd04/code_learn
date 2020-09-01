using System.Linq;
using System.Collections.Generic;
using PriorityQueues;
using System;
namespace Minimum_Spanning_Trees
{
    class LazyPrimsAlgorithm
    {
        MinHeap<Edge> minHeap ;
        Graph graph;
        int vertices;

        public LazyPrimsAlgorithm(Graph graph)
        {
            this.graph = graph;
            this.vertices = graph.Vertices;

        }
        public void Run()
        {
            var len = graph.EdgeList1.Count;
            List<Edge> l = new List<Edge>();

            int i=0,edgeCount=0;
            while(edgeCount< graph.Vertices-1)
            {
                var c = graph.GetIterator(i).GetIterator().ToArray().Select(x => x as Edge).ToArray();
                if(minHeap==null)
                    minHeap = new MinHeap<Edge>(c, c.Length);
                else
                    minHeap.Add(c, c.Length);
                minHeap.Sort();
                foreach(var e in l)
                {
                    minHeap.Delete(e);
                }
                var minEdge = minHeap.Pop();
                if(minEdge!=null)
                {
                      minEdge.Isblack=true;
                        i = minEdge.Other;
                l.Add(minEdge);
                }
                edgeCount++;
            }
            foreach(var l1 in l)
            {
                Console.WriteLine(l1);
            }
        }

    }
}
