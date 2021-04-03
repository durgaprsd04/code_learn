using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Dynamic_Greedy_backtracking
{
    public class DynamicProgramming
    {
        //check if array has elements that can form sum m
        public bool SubSetSum(int [] array, int m )
        {
            //Array.Sort(array);
            var len = array.Length;
            bool [][] result = new bool [len+1][];
            for(int i=0;i<len+1;i++)
            {
                result[i] = new bool[m+1];
            }
            for(int i=0;i<m+1;i++)
            {
                result[0][i]=false;
            }
            for(int i=0;i<len+1;i++)
            {
                result[i][0]=true;
            }
            for(int i=1;i<len;i++)
            {
                for(int j=1;j<m+1;j++)
                {
                    if(j> array[i-1])
                    {
                        result[i][j] = result[i-1][j];
                    }
                    else
                    {
                        result[i][j] = result[i-1][j]||result[i-1][j-array[i]];
                    }
                }
            }
            return result[len][m];

        }
        //a knapsack can stand a maximum weight of W has corresponding values in val array, what is the maximum value that can be selected under the given weight 
        //[W=7 , n =4 , wt = [1,3,4,5], val=[1,4,5,7]]
        public int KnapSack01(int W, int []wt , int [] val, int n)
        {
            int [][] dp = new int[n][];
            for(int i=0;i<n;i++)
            {
                dp[i] = new int [W+1];
            }
            //weight is in columns
            // for weight zero no number of items can come up with zero wieght
            for(int i=0;i<n;i++)
            {
                dp[i][0]=0;
            }
            for(int i=0;i<n;i++)
            {
                for(int j=1;j<W+1;j++)
                {
                    if(j <wt[i])
                        dp[i][j] = dp[i-1][j];
                    else
                        if(i>=1)
                        {
                            dp[i][j] = Math.Max(dp[i-1][j], val[i]+dp[i-1][j-wt[i]]);
                        }
                        else
                        {
                            dp[i][j] = Math.Max(dp[i][j-wt[i]], val[i]);
                        }
                }
            }
            for(int i=0;i<n;i++)
            {
                Console.Write($"({val[i]}){wt[i]} ");
                for(int j=0;j<W+1;j++ )
                {
                    Console.Write(dp[i][j] +"  ");
                }
                Console.WriteLine();
            }
            return dp[n-1][W];
        }

        public bool SubSetSum1(int [] arr , int target)
        {
            // to create an array of size arraylenth * target+1
            var len  = arr.Length;
            var targetSum = new int[len+1][];
            var flag=false;
            for(int i=0;i<(len+1);i++)
            {
                targetSum[i] = new int[target+1];
            }
            for(int i=0;i<(len+1);i++)
            {
                targetSum[i][0] =0;
            }
            for(int i=1;i<len+1;i++)
            {
                for(int j=1;j<target+1;j++)
                {
                    if(arr[i-1]<=j)
                    {
                        targetSum[i][j] = Math.Max(targetSum[i-1][j], arr[i-1]+targetSum[i-1][j-arr[i-1]]);
                    }
                    else{
                        targetSum[i][j] = targetSum[i-1][j];
                    }
                    if(targetSum[i][j]==target)
                    {
                        flag=true;
                        break;
                    }
                }
            }
            for(int i=0;i<len+1;i++)
            {
                if(i-1>=0)
                    Console.Write("("+arr[i-1] +") ");
                else 
                    Console.Write("(0) ");
                for(int j=0;j<target+1;j++)
                    Console.Write(targetSum[i][j]+"  ");
                Console.WriteLine();
            }
            return flag;
        }
        public int SubSetSumCount(int [] arr , int target)
        {
            // to create an array of size arraylenth * target+1
            var len  = arr.Length;
            var targetSum = new int[len+1][];
            for(int i=0;i<(len+1);i++)
            {
                targetSum[i] = new int[target+1];
            }
            for(int i=0;i<(len+1);i++)
            {
                targetSum[i][0] =1;
            }
            for(int i=1;i<len+1;i++)
            {
                for(int j=1;j<target+1;j++)
                {
                    if(arr[i-1]<=j)
                    {
                        targetSum[i][j] =  targetSum[i-1][j]+  targetSum[i-1][j-arr[i-1]];
                    }
                    else{
                        targetSum[i][j] = targetSum[i-1][j];
                    }
                }
            }

            for(int i=0;i<len+1;i++)
            {
                if(i-1>=0)
                    Console.Write("("+arr[i-1] +") ");
                else 
                    Console.Write("(0) ");
                for(int j=0;j<target+1;j++)
                    Console.Write(targetSum[i][j]+"  ");
                Console.WriteLine();
            }
            return targetSum[len][target];
        }        
        public (int a, int b) MinSubSetSum(int [] arr)
        {
            var len = arr.Length;
            var sum = arr.Sum();
            var SubSetSum = new bool[sum+1];
            SubSetSum[0]=true;
            for(int i=0;i<len;i++)
            {
                for(int j=sum; j>=arr[i];j--)
                {
                    SubSetSum[j] = SubSetSum[j] || SubSetSum[j-arr[i]];
                }
            }
            var min = Int32.MaxValue;
            var mainA=0;
            var mainB=0;
            for(int i=0;i<=sum/2;i++)
            {
                if(SubSetSum[i])
                {
                    var a = i;
                    var b = sum-i;
                    if(Math.Abs(a-b)<min)
                    {
                        min = Math.Abs(a-b);
                        mainA=a;
                        mainB=b;
                    }
                }
            }
            return (mainA,mainB);
        }
        public int UnboundedKnapsack(int W, int []wt , int [] val, int n )
        {
             var dp = new int[W+1];
             //for(int i=0;i<n+1;i++)
              //  dp[i] = new int[W+1];
            
            //for(int i=0;i<n+1;i++)
            //    dp[i][0]=0;
            /*
            for(int i=0;i<W+1;i++)
            {
                for(int j=1;j<n+1;j++)
                {
                    if(wt[j-1]<=i)
                    {
                        dp[i] = Math.Max(dp[i-1], val[j-1] + dp[i-wt[j-1]]);
                    }
                }
                Console.WriteLine(string.Join(" ", dp));
            }
            */
             for (int i=0; i<=W; i++)
             {
                for (int j=0; j<n; j++)
                    if (wt[j] <= i)
                        dp[i] = Math.Max(dp[i], dp[i-wt[j]] + val[j]);
                Console.WriteLine(string.Join(" ", dp));
             }
            return dp[W];

        }
        public int CoinChange(int [] coins, int n)
        {
            var len = coins.Length;
            var dp = new int[len+1][];
            for(int i=0;i<len+1;i++)
                dp[i] = new int[n+1];
            
            

            for(int i=0;i<len+1;i++)
            {
                for(int j=1;j<n+1;j++)
                {    //impossible condition
                    dp[i][j] = Int32.MaxValue;
                }
            }
            for(int i=0;i<len+1;i++)
                dp[i][0]=0;

                        
            for(int i=1;i<len+1;i++)
            {
                for(int j=1;j<n+1;j++)
                {
                    dp[i][j] = dp[i - 1][j] != Int32.MaxValue ? dp[i - 1][j] : dp[i][j]; // exclude
                    if(j>=coins[i-1])
                    {
                        if(dp[i][j-coins[i-1]]!=Int32.MaxValue)
                            dp[i][j] = Math.Min(dp[i][j] ,dp[i][j-coins[i-1]]+1); 
                    }
                    
                }
            }
            /*
            for (int i = 1; i <= len; i++) {
            for (int amt = 1; amt <= n; amt++) {
                dp[i][amt] = dp[i - 1][amt] != Int32.MaxValue ? dp[i - 1][amt] : dp[i][amt]; // exclude
                if (coins[i - 1] <= amt && dp[i][amt - coins[i - 1]] != Int32.MaxValue) {
                    dp[i][amt] = Math.Min(dp[i][amt], dp[i][amt - coins[i - 1]] + 1); // include
                }
            }
        }*/
            for(int i=0;i<len+1;i++)
            {
                for(int j=0;j<n+1;j++)
                {
                    Console.Write(dp[i][j]+" ");
                }
                Console.WriteLine();
            }
            return dp[len][n];

        }
    }
     public class BackTracking
        {
            public IList<IList<int>> Permute(int[] nums)
            {        
                var isMarked = new bool [nums.Length];
                IList<IList<int>>  mainList= new List<IList<int>>();
                var list = new List<int>();
                func(nums, isMarked, nums.Length, list, mainList);
                return mainList;        
            }
            public void func(int [] nums, bool [] isMarked, int len, List<int> list, IList<IList<int>> mainList)
            {
                Console.WriteLine(string.Join(",",isMarked));
                //Console.ReadKey();
                if(list.Count>len)
                    return;
                var l1  = new List<int>(list);
                for(int i=0;i<len;i++)
                {
                    if(!isMarked[i])
                    {
                        l1.Add(nums[i]);
                        isMarked[i]=true;
                    }
                    else
                        continue;
                    if(l1.Count==len)
                    {
                        Console.WriteLine(string.Join(",",l1));
                        mainList.Add(new List<int>(l1));
                        l1.Clear();
                    }
                    else
                    {
                        //Console.WriteLine(string.Join(",",list));
                        func(nums, isMarked, len, new List<int>(l1), mainList);
                        l1.RemoveAt(l1.Count-1);
                    }
                    isMarked[i]=false;
                }
            }
            public int NumTilePossibilities(string tiles)
            {
                var len = tiles.Length;
                var isMarked = new bool [len];
                var list = new List<string>();
                var sb = new StringBuilder();
                Func(tiles, len, isMarked,sb, list);
                Console.WriteLine(string.Join(",", list));
                return list.Count;        
            }
            public void Func(string tiles, int len,bool[] isMarked, StringBuilder sb, List<string> list)
            {
                var sb1 = new StringBuilder(sb.ToString());
                for(int i=0;i<len;i++)
                {           
                    if(!isMarked[i])
                    {
                        sb1.Append(tiles[i]);
                        isMarked[i]=true;
                    }
                    else
                        continue;
                    if(sb1.Length!=0)
                    { 
                        var res = sb1.ToString();
                        Console.Write(res+" ");
                        if(!list.Contains(res))
                            list.Add(res);
                    }
                    else
                        continue;
                    Func(tiles, len, isMarked, new StringBuilder(sb1.ToString()), list);
                    if(sb1.Length>=2)
                        sb1.Remove(sb1.Length-2,1);
                    else if(sb1.Length==1)
                        sb1.Remove(0,1);
                    isMarked[i]=false;
                    
                }
            }
            public int GetMaximumGold(int[][] grid) {
                
                var m = grid.Length;
                var n = grid.FirstOrDefault().Length;
                List<Tuple<int,int>> listOfGolds = new List<Tuple<int,int>>();
                var max =0;
                for(int i=0;i<m;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        if(grid[i][j]!=0)
                        {
                            listOfGolds.Add(new Tuple<int,int>(i,j));
                        }
                    }
                }
                for(int i=0;i<listOfGolds.Count;i++)
                {
                    var gold= CollectGold(listOfGolds[i], grid, m, n);
                    if(gold>max)
                        max=gold;
                }
                return max;
            }
            public int CollectGold( Tuple<int,int> tuple, int [][] grid,int m, int n)
            {
                var isVisited = new bool[m][];
                for(int i=0;i<m;i++)
                        isVisited[i]= new bool[n];
                return CollectGold(tuple, grid, m, n, isVisited);
            }
            public IList<IList<int>> Combine(int n, int k) {
                Stack<int> stack = new Stack<int>();
                IList<IList<int>> solution =new List<IList<int>>();
                bool [] isVisited = new bool[n];
                List<int> list = new List<int>();
                HashSet<string> hs = new HashSet<string>();
                Combination(list, n , k , isVisited,  solution,  hs);
                return solution;
            }
            public void Combination(List<int> list, int n, int k, bool [] isVisited,  IList<IList<int>> solution,  HashSet<string> hs)
            {
                for(int i=1;i<=n;i++)
                {
                    if(i==2)
                        Console.WriteLine(string.Join(",", isVisited));
                    if(!isVisited[i-1])
                    {
                        //Console.Write($"{i}  [{string.Join(",",list)}] ");
                        isVisited[i-1]=true;
                        
                        if(list.Count()<k)
                            list.Add(i);
                        
                        if(list.Count()==k)
                        {
                        list.Sort();
                        var str = string.Join("",list);
                            if(!hs.Contains(str))
                            {
                                solution.Add(new List<int>(list)); 
                                hs.Add(str);
                            }
                        }
                        else
                        {
                            Combination(new List<int>(list), n, k, isVisited,  solution,  hs);
                        }
                        list.RemoveAt(list.Count()-1);
                        isVisited[i-1]=false;
                    }
                }
            }
            public int CollectGold(Tuple<int,int> tuple, int [][] grid,int m, int n, bool [][] isVisited)
            {
                isVisited[tuple.Item1][tuple.Item2]=true;
                var adjCell = tuple;
                var max= grid[tuple.Item1][tuple.Item2];
                while(adjCell.Item1!=-1)
                {
                    Console.Write(grid[adjCell.Item1][adjCell.Item2] +"  ");
                    adjCell = GetAdjCell(adjCell, grid, m, n, isVisited);
                    if(adjCell.Item1!=-1)
                        max += grid[adjCell.Item1][adjCell.Item2];
                }
                Console.WriteLine();
                return max;
            }
            public Tuple<int,int> GetAdjCell(Tuple<int,int> tuple, int [][] grid,int m, int n,bool[][] isVisited)
            {
                var max =0;
                Tuple<int,int> result = new Tuple<int,int>(-1,-1);
                List<Tuple<int,int>> tupleList = new List<Tuple<int,int>>();
                for(int i=-1;i<=1;i++)
                {
                    for(int j=-1;j<=1;j++)
                    {
                        if(i+tuple.Item1<m && j+tuple.Item2<n && i+tuple.Item1>=0 && j+ tuple.Item2>=0)
                        {
                            if(Math.Abs(i)!=Math.Abs(j))
                            {
                                if(!isVisited[i+tuple.Item1][j+tuple.Item2])
                                {
                                    if(grid[i+tuple.Item1][j+tuple.Item2]!=0)
                                    {
                                        if(grid[i+tuple.Item1][j+tuple.Item2]>max)
                                        {
                                            max =grid[i+tuple.Item1][j+tuple.Item2];
                                            if(result.Item1!=-1)
                                                isVisited[result.Item1][result.Item2]=false;

                                            result =new Tuple<int,int> (i+tuple.Item1, j+tuple.Item2);
                                            isVisited[result.Item1][result.Item2]=true;
                                        }
                                    }
                                }
                            }
                        }
                                
                    }
                }
                return result;
            }
            public IList<IList<string>> Partition(string s) {
        var len = s.Length;
        var sb = new StringBuilder();
        var dict = new Dictionary<int,List<string>>();
        var isMarked = new bool[len];
        
        for(int i=1;i<=len;i++)
        {
            dict.Add(i, new List<string>());
        }
        
        Func(s, len, sb, dict, isMarked);
        IList<IList<string>> result = new List<IList<string>>( dict.Values.ToList());
        
        return result;
        //return dict.Values.ToList();
    }
            public void Func(string s, int len, StringBuilder sb, Dictionary<int, List<string>> dict, bool [] isMarked)
            {
                sb = new StringBuilder(sb.ToString());
                if(sb.Length>len)
                    return ;
                for(int i=0;i<len;i++)
                {
                    if(!isMarked[i])
                    {
                        isMarked[i]=true;
                        sb.Append(s[i]);
                        Console.Write(sb.ToString()+ "  ");
                        if(IsPal(sb.ToString()))
                        {
                            dict[sb.Length].Add(sb.ToString());
                        }
                        Func(s, len, new StringBuilder(sb.ToString()), dict, isMarked);
                        if(sb.Length>=1)
                            sb.Remove(sb.Length-1,1);
                    }
                    isMarked[i]=false;
                }
            }
            public bool IsPal(string s)
            {
                bool flag=true; 
                for(int i=0;i<s.Length/2;i++)
                {
                    if(s[i]!=s[s.Length-i-1])
                    {
                        flag=false;
                        break;
                    }
                }
                return flag;
            }
            public int MaxUniqueSplit(string s) {
                        
                    int len = s.Length;
                    var isMarked = new bool [len];
                    HashSet<string> hs = new HashSet<string>();
                    
                    var res = Func(s, 0, len, isMarked, hs);
                    Console.WriteLine(string.Join(",", hs));
                    return hs.Count();
                }
            public bool Func(string s,int start,  int len , bool [] isMarked, HashSet<string> hs)
            {
            var sb = new StringBuilder();
            for(int i=start;i<len;i++)
            {
                if(!isMarked[i])
                {
                    sb.Append(s[i]);
                    isMarked[i]=true;
                    if(!hs.Contains(sb.ToString()))
                    {
                        hs.Add(sb.ToString());
                    }
                    else
                    {
                        if(i+1==len)
                        {
                            isMarked[i]=false;
                            return false;
                        }
                        else
                        {
                            //isMarked[i]=false;
                            continue;
                        }
                    }
                    var res = Func(s, i+1, len, isMarked, hs);
                    if(!res)
                    {
                        hs.Remove(sb.ToString());
                         isMarked[i]=false;
                        
                    }
                   
                    //return true;
                }
            }
            return true;
        }
            public int MinSubSetSum(int [] nums)
            {
                var len = nums.Length;
                var isMarked = new bool[len];
                var sum = nums.Sum();
                List<int> l = new List<int>();
                var tupleList = new List<Tuple<int,int>>();
                Func(nums, len, isMarked, sum, l, tupleList);
                Console.WriteLine(string.Join(", ", tupleList));
                return 0;
            }
            public void Func(int [] nums, int len, bool [] isMarked, int sum, List<int> list, List<Tuple<int,int>> pairList)
        {
            for(int i=0;i<len;i++)
            {
                 if(!isMarked[i])
                 {
                    isMarked[i]=true;
                    list.Add(nums[i]);
                    pairList.Add(new Tuple<int, int>(list.Sum(), sum - list.Sum()));
                    Func(nums, len , isMarked, sum, new List<int>(list), pairList);
                    list.RemoveAt(list.Count()-1);
                    isMarked[i]=false;
                 }
            }
        }
        }
        
    }
        public class SldingWindow
        {
          public string MinWindow(string s, string t) {

            var len = s.Length;
            HashSet<char> hs  = new HashSet<char>();
            for(int j=0;j<t.Length;j++)
                hs.Add(t[j]);
            var backup=hs;
            int i=0;
            var st =0;
            var lt=0;
            int startIndex =0, lastIndex =0, max=0, count=0;
            while(i<len)
            {
                if(hs.Remove(s[i]))
                {
                    Console.WriteLine($" removed {s[i]} start {startIndex} lst {lastIndex}");
                    if(hs.Count()==t.Length-1)
                        startIndex=i;
                    lastIndex=i;
                }
                if(hs.Count()==0)
                {
                    hs = backup;
                    i = startIndex;
                    count = lastIndex - startIndex;
                    startIndex = lastIndex;
                    if(count>max)
                    {
                        max =count;
                        lt = lastIndex;
                        st = lastIndex-count;
                    }
                }
                i++;
            }
            var sb = new StringBuilder();
            for(int j=0;j<count;j++)
            {
                sb.Append(s[j+st]);
            }
        return sb.ToString();
                 
        }
            
        }

        public class BitManipulation
        {
            public void BitShift(int n)
            {
                while(n>0)
                {
                    n=n>>1;
                    Console.Write(n);
                }
                Console.WriteLine();

            }  
            public int GetSum(int a, int b) {
     
        var backa =a;
        var backb =b;
        Stack<int> stack = new Stack<int>();
        while(a>0 || b>0)
        {
            Console.WriteLine($"a {a} b{b}");
            var a1 = a&1;
            var b1 = b&1;
            Console.WriteLine($"a1 {a1} b1 {b1}");
            if((b1^a1)==0)
            {
                if(b1==1||a1==1)
                    stack.Push(0);
                else
                    stack.Push(0);
            }
            else
            {
                stack.Push(1);
            }
            a=a>>1;
            b=b>>1;
        }
        Console.WriteLine(string.Join(",",stack)); 
        var result =0;
        while(stack.Count()>0)
            {
                result=result<<1;
                 Console.WriteLine(result);
                if(stack.Pop()==1)
                    result=result^1;  
            }
        return result;
    } 
        }
        public class BitManip
        {
            public int GetSum(int a, int b) {
     
        var backa =a;
        var backb =b;
        Stack<int> stack = new Stack<int>();
        while(a>0 || b>0)
        {
            Console.WriteLine($"a {a} b{b}");
            var a1 = a>>1;
            var b1 = b>>1;
            if((b1^a1)==0)
            {
                if(b1==1)
                    stack.Push(1);
                else
                    stack.Push(0);
            }
            else
            {
                stack.Push(1);
            }
            a=a/2;
            b=b/2;
        }
        Console.WriteLine(string.Join(",",stack)); 
        return 0;
    }
        }
        public class Solution {
    public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king) {
               
        var len = queens.Length;
        
        IList<IList<int>> result = new List<IList<int>>();
        
        var cornerCells = GetCornerCells(king);
        var horizCells = GetHorCells(king);
        var vertCells = GetVerCells(king);
        
        
        for(int i=0;i<len;i++)
        {
            var res =new Tuple<int,int>(queens[i][0],queens[i][1]);
            var list = new List<int>();
            if(cornerCells.Contains(res))
            {
                cornerCells.Remove(res);
                list.Add(queens[i][0]);
                list.Add(queens[i][1]);
                result.Add(new List<int>(list));
                list.Clear();
            }
            if(horizCells.Contains(res))
            {
                horizCells.Remove(res);
                list.Add(queens[i][0]);
                list.Add(queens[i][1]);
                result.Add(new List<int>(list));
                list.Clear();
            }
            if(vertCells.Contains(res))
            {
                vertCells.Remove(res);
                list.Add(queens[i][0]);
                list.Add(queens[i][1]);
                result.Add(new List<int>(list));
                list.Clear();
            }
        }
        return result;
    }
    public List<Tuple<int,int>> GetCornerCells(int[] king)
    {
        List<Tuple<int,int>> l1 = new List<Tuple<int,int>>();
        for(int i=-1;i<=1;i++)
        {
            for(int j=-1;j<=1;j++)
            {
                if(Math.Abs(i)==Math.Abs(j)&& (king[0]+i)<8 && (king[1]+j)<8 && (king[0]+i)>=8 && (king[1]+j)>=0)
                {
                    l1.Add(new Tuple<int,int>(king[0]+i, king[1]+j));
                }
            }
        }
        return l1;
    }
    public List<Tuple<int,int>> GetHorCells(int [] king)
    {
        List<Tuple<int,int>> l1 = new List<Tuple<int,int>>();
        if(king[1]+1<8)
            l1.Add(new Tuple<int,int>(king[0], king[0]+1));
        if(king[1]-1>=0)
            l1.Add(new Tuple<int,int>(king[0], king[0]-1));
        return l1;
    }
    public List<Tuple<int,int>> GetVerCells(int [] king)
    {
        List<Tuple<int,int>> l1 = new List<Tuple<int,int>>();
        if(king[0]+1<8)
            l1.Add(new Tuple<int,int>(king[0]+1, king[1]));
        if(king[0]-1>=0)
            l1.Add(new Tuple<int,int>(king[0]-1, king[1]));
        return l1;
    }
}