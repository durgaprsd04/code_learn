using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MaximumDepthBSTClass
    {
        public int MaxDepth(TreeNode root)
        {
            if(root==null)
              return 0;
             var mleft =  1+ MaxDepth(root.left);
             var mright = 1+ MaxDepth(root.right);
             return  ((mleft>mright)?mleft:mright);
        }
    }
}
