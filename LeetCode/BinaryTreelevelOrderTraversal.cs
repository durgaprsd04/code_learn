using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class BinaryTreelevelOrderTraversal
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<TreeNode> listofTreeNodes = GetChildNodes(new List<TreeNode>(){root});
            IList<int> listOfVals = new List<int>();
            IList<IList<int>> finalList  = new List<IList<int>>();
            listOfVals.Add(root.val);
            finalList.Add(listOfVals);
            while(listofTreeNodes.Count>0)
            {
                listOfVals = listofTreeNodes.Select(x => x.val).ToList();
                finalList.Add(listOfVals);
                List<TreeNode> l2 = new List<TreeNode>();
                var l = GetChildNodes(listofTreeNodes);
                Console.Write(l.Count);
                foreach(var v1 in l)
                  l2.Add(v1);
                listofTreeNodes = l2;
            }
            return finalList.Reverse().ToList();
        }
        public List<TreeNode> GetChildNodes(List<TreeNode> nodeList)
        {
          List<TreeNode> listOfTrees = new List<TreeNode>();
            foreach(var node in nodeList)
            {
              if(node.left!=null)
                listOfTrees.Add(node.left);
              if(node.right!=null)
                listOfTrees.Add(node.right);
            }
            return listOfTrees;
        }
    }
}
