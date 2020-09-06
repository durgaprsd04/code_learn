using System;
using System.Collections;
using System.Collections.Generic;
namespace Directed_Graphs
{
    public class DepthFirstSearch
    {
        private DirectedGraph graph;
        public bool [] isVisited;
        public int[] edgeTo;
        ////private Stack<int> cycle;
        //private bool [] OnStack;
        Queue postorder = new Queue();
        Queue preOrder = new Queue();
        Stack reversePostOrder = new Stack();
        public DepthFirstSearch(DirectedGraph graph)
        {
            this.graph=graph;
            isVisited = new bool [graph.Vertices];
            edgeTo = new int[graph.Vertices];
            //OnStack = new bool [graph.Vertices];
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
                    PreOrder.Enqueue(i);
                    Dfs(i);
                    postorder.Enqueue(i);
                    reversePostOrder.Push(i);
                }
            }
        }
        public void Dfs(int i)
        {
            var adj = graph.Adj(i);
            while(adj.Count>0)
            {
                int vertice= Convert.ToInt32(adj.Dequeue());
                if(!isVisited[vertice])
                {
                  edgeTo[vertice]=i;
                  isVisited[vertice]=true;
                  preOrder.Enqueue(vertice);
                  Dfs(vertice);
                  postorder.Enqueue(vertice);
                  reversePostOrder.Push(vertice);
                }
            }
        }
       public  Queue PostOrder{
            get{ return postorder;}
        }
       public Queue PreOrder{
         get{return preOrder;
         }
       }
       public Stack ReversePostOrder
       {
        get
        {
          return reversePostOrder;
        }
       }
        internal void Print()
        {
           var vertices = graph.Vertices;
           for(int i=0;i<vertices;i++)
           {
               Console.WriteLine("{0} {1} {2}", i, isVisited[i], edgeTo[i]);
           }
            Console.WriteLine(string.Join(',',postorder.ToArray()));
        }
    }
}
