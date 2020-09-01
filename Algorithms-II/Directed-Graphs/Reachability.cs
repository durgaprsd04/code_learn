using System;
using System.Collections;

namespace Directed_Graphs
{
    public class Reachability
    {
          public bool Reachable(DirectedGraph g, int v, int w)
          {
            DepthFirstSearch df = new DepthFirstSearch(g);
            df.Dfs(v);
            return  df.isVisited[w];
          }
    }
}
