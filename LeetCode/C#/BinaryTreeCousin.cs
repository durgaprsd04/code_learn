using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class BinaryTreeCousin
    {                
       public class ParentList
        {
            public int? parent;
            public int child;
            public ParentList(int? parent, int child)
            {
                this.parent =parent;
                this.child = child;
            }
            public override string  ToString()
            {
                return $"parent {parent} child {child}";
            }
        }
        public bool IsCousins(TreeNode root, int x, int y) 
        {
            var list = GetLevelOrder(root);
            var res =false;
            foreach (var item in list)
            {
                Console.WriteLine(string.Join(',',item));
                if(item.Select(x=>x.child).ToList().Contains(x) &&  item.Select(x=>x.child).ToList().Contains(y))
                {
                    var v1 = item.Where(a=> a.child==x).ToList().FirstOrDefault();
                    var v2 = item.Where(a=> a.child==y).ToList().FirstOrDefault();
                    if(v1.parent!=v2.parent)
                        res = true;
                }
            }
            return res;
        }
        public List<List<ParentList>> GetLevelOrder(TreeNode node)
        {
            var  mainList = new List<List<ParentList>>();
            var tempList = new List<TreeNode>(){ node };
            var list1 = new List<TreeNode>(){};
            var v1 =new ParentList(null, node.val);           
            var list =  new List<ParentList>();
            list.Add(v1);
            while(tempList.Count>0)
            {                
                mainList.Add(new List<ParentList>(list));
                list.Clear();
                foreach (var item in tempList)
                {
                    if(item.right!=null)
                    {
                        var v = new ParentList(item.val,item.right.val);
                        list.Add(v);
                        list1.Add(item.right);
                    }
                    if(item.left!=null)
                    {
                        var v =new ParentList(item.val, item.left.val);
                        list.Add(v);
                        list1.Add(item.left);
                    }
                }                    
                tempList = new List<TreeNode>(list1);
                list1.Clear();             
                
            }
            return mainList;
        }
    }
}
