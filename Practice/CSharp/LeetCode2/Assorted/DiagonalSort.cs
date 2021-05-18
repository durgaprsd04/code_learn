using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode2
{
    public class MatrixAlgorithms
    {
        public int  [][] DiagonalSort(int [][] mat)
        {
            var m = mat.Length;
            var n = mat.FirstOrDefault().Count();
            List<int> l = new List<int>();
            Console.WriteLine("here ");
            
            for(int i=m-1;i>=0;i--)
            {
                for(int j=0;j<n;j++)
                {
                    for(int k=0;k<=j;k++)
                    {
                        l.Add(mat[i][k]);
                    }
                    Console.WriteLine(string.Join(", ", l));
                    l.Clear();
                }
            }
            var m1 = new int[1][];
            m1[0] = new int[1]{3};
            return m1;
        }
    }
}