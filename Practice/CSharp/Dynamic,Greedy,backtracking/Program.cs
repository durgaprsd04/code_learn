using System;

namespace Dynamic_Greedy_backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DynamicProgramming dp = new DynamicProgramming();
            /* Knapsack problems1*/
            var result = dp.KnapSack01(7, new int[]{1,3,4,5} , new int[] {1,4,5,7}, 4);
            Console.WriteLine($"Maximum value from knapSack {result}");
            
            
            
            
            /*
            BackTracking bt = new BackTracking();
            var arr = new int[]{1,2,3};
            var res = bt.Permute(arr );
            var str ="AAB";
           bt.NumTilePossibilities(str);
           var input = new int[5][];
           input[0] = new int[]{1,0,7,0,0,0};
            input[1] = new int[]{2,0,6,0,1,0};
            input[2] = new int[]{3,5,6,7,4,2};
            input[3] = new int[]{4,3,1,0,2,0};
            input[4] = new int[]{3,0,5,0,20,0};
            */
           // bt.GetMaximumGold(input);
           //bt.Combine(4, 2);
           //bt.Partition("aab");
           //bt.MaxUniqueSplit("aba");
            //var sliding = new SldingWindow();
            //sliding.MinWindow("ADOBECODEBANC","ABC");

            //var bitmanip = new BitManipulation();
            //bitmanip.BitShift(16);
            //bitmanip.BitShift(20);
            //var result = bitmanip.GetSum(6,5);
            //Console.WriteLine("result of sum"+result);
        }
    }
}
