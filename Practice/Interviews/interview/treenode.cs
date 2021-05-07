using System;
using System.Threading;
namespace interview
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val, TreeNode left,TreeNode right)
        {
            this.val = val;
            this.right =right;
            this.left = left;
        }
    }
 //      10
 //     /    \
//    5       50
 //  /       /  \
// 1       40   100
    public class Worker
    {
        public void Method()
        {
            
            var left = new TreeNode(5, new TreeNode(1, null,null), null);
            var right = new TreeNode(50, new TreeNode(40,null,null), new TreeNode(100,null,null));
            var t1 = new TreeNode(10,left,right);
            var res = SearchRangecount(t1, 10,100);
            Console.WriteLine("Result "+ res);

        }
        public int SearchRangecount(TreeNode root, int a, int b)
        {
             
                if(root==null)
                    return 0;
                Console.WriteLine($"a {a} root {root.val}");
                Console.ReadKey();
                if(root.left==null && root.right==null)
                {
                    if(root.val>=a && root.val<=b)
                        return 1;
                    else 
                        return 0;
                }
                if(a>root.val)
                    return SearchRangecount(root.right, a, b);
                else if(b<root.val)
                    return SearchRangecount(root.left, a, b);
                else
                {
                     return 1+ SearchRangecount(root.left, a, b)  + SearchRangecount(root.right, a, b);
                }
        }
    }

    public sealed class SingleTonTest
    {
        private SingleTonTest _singleTonObject;
        private object obj=new object();
        private SingleTonTest()
        {
            
        }
        public SingleTonTest GetInstance()
        {
            lock(obj)
            {
                if(_singleTonObject!=null)
                    return new SingleTonTest();
                else
                    return _singleTonObject;
            }
        }
    }
}