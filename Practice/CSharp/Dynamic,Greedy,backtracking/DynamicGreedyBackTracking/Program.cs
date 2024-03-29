﻿using System;
using System.Linq;
using  System.Collections.Generic;

namespace Dynamic_Greedy_backtracking
{
    class Program
    {

        public static void Main(string [] args)
        {
            // simple dp questions
            //DynamicProgramming2 dp2 = new DynamicProgramming2();
            /* some simple question*/
            //var result = dp2.GetTotalNumberOfSequences(5,3, new HashSet<int>());
            //Console.WriteLine($"The number for sum {10} and n count {4} is result {result}");
            /* product of Longest INCreasing SubSequence*/
            //var res = dp2.MaximumProductOfLongestIncreasingSubSeq(new int []{10, 22, 9, 33, 21, 50, 41, 60});
            //Console.WriteLine($"The LIS product result {res}");
            /* MAx sub sequnce sum*/
            /*
            var arr = new int [][]{
                new int []{1, 2, 3},
                new int []{3000, 2000, 1000, 3, 10},
                new int []{100, 1000, 100, 1000, 1},
                new int []{1, 1, 1, 1, 1},
                new int []{1, 2, 3, 4, 5, 6, 7, 8}
            };
            foreach(var v in arr)
            {
                var result2 = dp2.MaxSubSequenceSum(v);
                Console.WriteLine($"The max sub sum of {string.Join(",", v)} is {result2}");
            }
            */
            /*
            var arr = new int[][]
            {
                new int []{10, 9, 4, 5, 4, 8, 6},
                new int []{1, 2, 3, 2, 3, 7, 2, 1}
            };
            foreach(var v in arr)
            {
                var result2 = dp2.GetLongestSubSequenceWithDifference1(v);
                Console.WriteLine($"The max sub sum of {string.Join(",", v)} is {result2}");
            }*/
            
            //var dp = new DynamicProgramming2();
            //var arr = new int[]{4,2,5,9};
           
             /*var data = new int [][]{new int[]{5, 24}, 
                                new int[]{39, 60}, 
                                new int[]{ 15, 28}, 
                                new int[] {27, 40}, 
                                new int[]{50, 90}};
                */
             //var data = new int [][]{new int[]{11, 20}, 
                            //    new int[]{10, 40}, 
                              //.  new int[]{ 45,60}, 
                                //new int[] {39, 40}};
                                //new int [] {110,200}};
        //When
        /*var result = dp.GetLongestPairLength(data);
        var result3 = dp.GetLongestPair(data);
        Console.WriteLine(string.Join(", ", result3.Select(x => "("+x[0]+","+ x[1]+")")));
        */
        //var res = dp.SubArrayWithMaxSum(new int[]{1, -2, 1, 1, -2, 1});
        //Console.WriteLine($" res {res}");
       
       /*
         var dp1 = new int[3][];
        for(int i=0;i<3;i++)
        {
                dp1[i] = new int[3]{3*i+1,3*i+2, 3*i+3};
        }
        var res = dp2.MaximumAverageValue(dp1,3);
        */
         var dp1 = new DynamicProgramming2();
         //   var result = dp1.GetNumberOfWaystoClimbStairs(8, new int[]{0,3,2,4,6,3,7,5,3});
          //  Console.WriteLine("Result is "+result);
            /*var arr = new int [4] [] ;
             arr [0]= new int [] { 4, 2, 3, 4 };
             arr[1] = new int [] { 2, 9, 1, 10 };
             arr[2] = new int [] { 15, 1, 3, 0 };
             arr[3] = new int [] { 16, 92, 41, 44 };
             var result = dp1.GetMaxValuePath(arr);*/
            

            //Console.WriteLine($"result {result}");
             var arr = new int []{1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9};
             var result = dp1.MinimumNumberOfJumpstoReachEnd(arr);
            Console.WriteLine("result "+result);
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            DynamicProgramming dp = new DynamicProgramming();
            BackTracking bt = new BackTracking();
            /* Knapsack problems1*/
            //var result = dp.KnapSack01(7, new int[]{1,3,4,5} , new int[] {1,4,5,7}, 4);
            //Console.WriteLine($"Maximum value from knapSack {result}");
            
            /*sum exists for a given number */
            //var isExists = dp.SubSetSum1(new int [] {1,5,5,11}, 11);
            //Console.WriteLine($"Subset sum for {11} exists {isExists}");

            /*count number of combinations number k can be generated */
            //var isExists2 = dp.SubSetSumCount(new int [] {2,2,2,2}, 4);
            //Console.WriteLine($"Number of way of making {4} from array {isExists2}");
            
            /*split an array numbers to two sets so that difference of their sum is minimum*/
            /*using backtracking*/
            //var diff = bt.MinSubSetSum(new int [] {1,5,6,11});
            //Console.WriteLine($"result is {diff}");
            //var minResult = dp.MinSubSetSum(new int[]{1,5,6,11});
            //Console.WriteLine($"result is a {minResult.a} b {minResult.b} ");
            
            /* Unbounded knapsack with wieghts*/
            //var tots = dp.UnboundedKnapsack(10, new int[]{1,2,3}, new int[]{3,7,1}, 3);
            //Console.WriteLine($"Unbounded result value {tots}");
            
            /*Coin change make value n with minimum number of coins*/
            //var tots2 = dp.CoinChange(new int []{2,5,1} , 11);
            //Console.WriteLine($"Minimum number of coins needed {tots2}");

            /*Longest increasing subsequnce length*/
            //var lisLength = dp.LongestIncreasingSubSequence(new int []{0,1,0,3,2,3});
            //Console.WriteLine($"longest increasing sub sequence length {lisLength}");
            
            /*Longest common subsequence */
            

            //dp.LongestCommonSubsequence("bsbininm","jmjkbkjkv");
            
            /*
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
