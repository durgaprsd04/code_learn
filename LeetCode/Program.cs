﻿using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Solution sol = new Solution();
            //int [] a = {1,1,1};
            //Console.WriteLine("sum" +string.Join(',', sol.RunningSum(a)));
            /*ListNode l = new ListNode(5);
            //l.next = new ListNode(4);
            //l.next.next= new ListNode(3);
            l.Traverse();
            ListNode l1 = new ListNode(5);
            //l1.next = new ListNode(6);
            //l1.next.next= new ListNode(4);
            l1.Traverse();
            */
            /*Solution2 sn = new Solution2();
            StreamReader sr = new StreamReader("input_longestsubstring.txt");
            while(sr.Peek()>0)
            {
                var l2 = sn.LengthOfLongestSubstring(sr.ReadLine());
                Console.WriteLine(l2);
            }
            */
            /*
            StreamReader sr = new StreamReader("input_longestpal.txt");
            Solution3 s3 = new Solution3();
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine();
              Console.WriteLine(v);
              var l2 = s3.LongestPalindrome(v);
              Console.WriteLine(l2);
            }
            *//*
             streamreader sr = new streamreader("input_zigzag.txt");
            zigzag s4 = new zigzag();
            while(sr.peek()>0)
            {
              var v = sr.readline().split(' ');;
              console.writeline(v[0] +" : "+v[1]);
              var l2 = s4.convert(v[0], convert.toint32( v[1]));
              console.writeline(l2);
            }*/
            /*
            StreamReader sr = new StreamReader("input_container.txt");
            ContainerWater wt  = new ContainerWater();
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var l2  = wt.MaxArea(v);
              Console.WriteLine(l2);
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs\input_roman.txt");
            NumberToRoman nr  = new NumberToRoman();
             Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v = Convert.ToInt32(sr.ReadLine());
              var l2  = nr.IntToRoman(v); 
              Console.WriteLine(v +" : "+l2);
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_3sum.txt");
            Threesum threesum  = new Threesum();
             Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var l2  = threesum.ThreeSum(v);
              foreach(var v1 in l2)
                Console.WriteLine(string.Join(',', v1.ToArray()));
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_nthNode.txt");
            RemoveNthNode nth = new RemoveNthNode();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var limit = Convert.ToInt32(sr.ReadLine());
              ListNode l=null;
              foreach(int v1 in v)
              {
                 l = new ListNode(v1, l);
              }
              l.Traverse();
              var v2 = nth.RemoveNthFromEnd(l,limit);
              v2.Traverse();
            }
          */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_swapPairNode.txt");
            SwapNodesInPair swp  = new SwapNodesInPair();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var limit = Convert.ToInt32(sr.ReadLine());
              ListNode l=null;
              foreach(int v1 in v)
              {
                 l = new ListNode(v1, l);
              }
              var v2 =swp.SwapPairs(l);
              v2.Traverse();
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_nextPerm.txt");
            NextPermutation2 next = new NextPermutation2();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v1 = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              Console.WriteLine(string.Join(',', v1));
              next.NextPermutation(v1);
              Console.WriteLine(string.Join(',', v1));
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_twosum.txt");
             TwoSumClass  twosum = new TwoSumClass();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
            {
              var v1 = sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var v2 = Convert.ToInt32(sr.ReadLine());
              Console.WriteLine(string.Join(',',v1)+" search for  "+v2 );
              var v3 = twosum.TwoSum(v1,v2);
              Console.WriteLine(string.Join(',', v3));
            }
            */
            /* 
              StreamReader sr = new StreamReader(@"inputs/input_reverseint.txt");
              ReverseInt reverse= new ReverseInt();
             Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
              var v2 = Convert.ToInt32(sr.ReadLine());
              var result = reverse.Reverse(v2);
              Console.WriteLine($"Reverse of {v2}: {result}");
             }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_romantoInt.txt");
             RomanToIntClass roman= new RomanToIntClass();
             Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
              var v2 = sr.ReadLine();
              var result = roman.RomanToInt(v2);
              Console.WriteLine($"Roman of {v2}: {result}");
             }
            */
            /*
             StreamReader sr = new StreamReader(@"inputs/input_ValidParenthesis.txt");
             ValidParenthesisClass validpara = new ValidParenthesisClass();
             Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
              var v2 = sr.ReadLine();
              var result = validpara.IsValid(v2);
              Console.WriteLine($"Result of {v2}: {result}");
             }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_twoSortedLists.txt");
             MergeTwoSortedLists merge = new MergeTwoSortedLists();
             Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var v2 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              ListNode l1=null, l2=null;
              foreach(int v3 in v1)
              {
                 l1 = new ListNode(v3, l1);
              }
              foreach(int v3 in v2)
              {
                 l2 = new ListNode(v3, l2);
              }
              var result = merge.MergeTwoLists(l1,l2);
              Console.Write($"Result of ");
              result.Traverse();
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_duplicateArray.txt");
            RemoveDuplicatesArray removeDuplicates = new RemoveDuplicatesArray();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
               Console.WriteLine("Array before duplicate removal "+ string.Join(',', v1));
               var result = removeDuplicates.RemoveDuplicates(v1);
               Console.WriteLine($"Result of  "+string.Join(',', v1)+" : "+ result.ToString());
             }
             */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_removeInstances.txt");
            RemoveAllInstances removeInstances = new RemoveAllInstances();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
               var v2 = Convert.ToInt32(sr.ReadLine());
               Console.WriteLine("Array before duplicate removal "+ string.Join(',', v1));
               var result = removeInstances.RemoveElement(v1, v2);
               Console.WriteLine($"Result of  "+string.Join(',', v1)+" : "+ result.ToString());
             }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_needle.txt");
            NeedleHaystack needle = new NeedleHaystack();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',');
               var v2 =v1[0];
               var v3 = v1[1];
               Console.WriteLine($"Needle {v3} haystack  {v2}");
               var result = needle.StrStr(v2, v3);
               Console.WriteLine("Result of  "+ result.ToString());
             }
            */
              /*
            StreamReader sr = new StreamReader(@"inputs/input_countAndSay.txt");
            CountAndSayClass count = new CountAndSayClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v2 =Convert.ToInt32(sr.ReadLine());
               var result = count.CountAndSay(v2);
               Console.WriteLine("Result of  "+v2+": "+ result.ToString());
             }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_maximumsubarray.txt");
            MaximumSubArrayClass max = new MaximumSubArrayClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
               var result = max.MaxSubArray(v1);
               Console.WriteLine("Result of  ["+string.Join(',',v1)+" ]: "+ result.ToString());
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_lengthOfLastWord.txt");
            LengthOfLastWordClass l = new LengthOfLastWordClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine();
               var result = l.LengthOfLastWord(v1);
               Console.WriteLine("Result of  ["+string.Join(',',v1)+" ]: "+ result);
             }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_plusOneClass.txt");
            PlusOneClass plus = new PlusOneClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
               var result = plus.PlusOne(v1);
               Console.WriteLine("Result of  ["+string.Join(',',v1)+" ]: "+ string.Join(',',result));
            }
          */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_TwoBinariesClass.txt");
            TwoBinariesClass two = new TwoBinariesClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
               var v1 =sr.ReadLine().Split(',');
               var result = two.AddBinary(v1[0], v1[1]);
               Console.WriteLine("Result of  [" + v1[0] + " + " +v1[1] +" ]: "+result);
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_RemoveDuplicates.txt");
            DeleteDuplicatesClass d = new DeleteDuplicatesClass();
            Console.WriteLine("hello");
             while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              ListNode l1=null;
              foreach(int v3 in v1)
              {
                 l1 = new ListNode(v3, l1);
              }
              var v = d.DeleteDuplicates(l1);
              Console.Write("Result of  ");
              Console.Write("answer ");
              Console.WriteLine();
              v.Traverse();
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_mergeSorted.txt");
            MergeSortedArrayClass ms = new MergeSortedArrayClass();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var m = Convert.ToInt32(sr.ReadLine());
              var v2 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var n = Convert.ToInt32(sr.ReadLine());
              int [] v3 = new int [m+n];
              for(int i=0;i<m;i++)
                v3[i] = v1[i];

              Console.WriteLine("Result of  [" +string.Join(',', v3) +"] [" +string.Join(',', v2) +"] ");
              ms.Merge(v3,m, v2,n);
              Console.WriteLine("Result of  [" +string.Join(',', v3) +"]");
             }
             */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_SameTree.txt");
            SameTreeClass sametree = new SameTreeClass();
            Console.WriteLine("hello");
            TreeNode res1=null,res2=null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
              var v2 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v2)
              {
                  if(res2==null)
                    res2 = new TreeNode(v,null,null);
                  else
                    res2.Add(new TreeNode(v, null,null));
              }

             }
            res1.Traverse();
            res2.Traverse();
            var result = sametree.IsSameTree(res1,res2);
            Console.WriteLine("Result of   ");
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_symmetric.txt");
            SymmetricTreeClass sym = new SymmetricTreeClass();
            Console.WriteLine("hello");
            TreeNode res1=null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
            }
            res1.Traverse();
            var result = sym.IsSymmetric(res1);
            Console.WriteLine("Result of   "+result);
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_maximum_depth.txt");
            MaximumDepthBSTClass max = new MaximumDepthBSTClass();
            Console.WriteLine("hello");
            TreeNode res1=null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
            }
            res1.Traverse();
            var result = max.MaxDepth(res1);
            Console.WriteLine("Result of   "+result);
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_levelOrder.txt");
            BinaryTreelevelOrderTraversal b = new BinaryTreelevelOrderTraversal();
            Console.WriteLine("hello");
            TreeNode res1=null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
            }
            res1.Traverse();
            var result = b.LevelOrderBottom(res1);
            foreach(var v in result)
            Console.WriteLine("Result of   "+string.Join( ',',v.ToArray()));
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_SortedArrayToBinarySearchTree108.txt");
            SortedArrayToBSTClass s = new SortedArrayToBSTClass();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var result = s.SortedArrayToBST(v1);
              Console.WriteLine("Result of   ["+string.Join( ',',v1) +"] ");
              //result.Traverse();
             }
             */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_balancedBinaryTree.txt");
            BalancedBinaryTree bbt = new BalancedBinaryTree();
            Console.WriteLine("hello");
            TreeNode res1 =null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
              var result = bbt.IsBalanced(res1);
              res1 = null;
              Console.WriteLine("Result of   ["+string.Join( ',',v1) +"] " + result);
             }
             */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_minDepthOfBinaryTree.txt");
            MinDepthBinaryTreeClass min = new MinDepthBinaryTreeClass();
            Console.WriteLine("hello");
            TreeNode res1 =null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
              var result = min.MinDepth(res1);
              res1 = null;
              Console.WriteLine("Result of   ["+string.Join( ',',v1) +"] " + result);
            }
            */
            /*
            StreamReader sr = new StreamReader(@"inputs/input_PathSumBST.txt");
            PathSumBST path = new PathSumBST();
            Console.WriteLine("hello");
            TreeNode res1 =null;
            while(sr.Peek()>0)
             {
              var v1 =sr.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
              var v2 = Convert.ToInt32(sr.ReadLine());
              foreach(var v in v1)
              {
                  if(res1==null)
                    res1 = new TreeNode(v,null,null);
                  else
                    res1.Add(new TreeNode(v, null,null));
              }
              var result = path.HasPathSum(res1,v2);
              res1 = null;
              Console.WriteLine("Result of   ["+string.Join( ',',v1) +"]  with sum "+v2+" :" + result);
            }
            */
            StreamReader sr = new StreamReader(@"inputs/input_PascalTriangle.txt");
            PascalTriangle pt = new PascalTriangle();
            Console.WriteLine("hello");
            while(sr.Peek()>0)
             {
              var v2 = Convert.ToInt32(sr.ReadLine());
              var result = pt.Generate(v2);
              Console.WriteLine("Result is ");
              foreach(var v in result)
                Console.WriteLine("["+string.Join( ',',v.ToArray()) +"]");
              Console.WriteLine();
            }


        }
    }
}
