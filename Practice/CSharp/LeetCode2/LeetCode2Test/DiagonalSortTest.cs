using System;
using Xunit;
using System.Collections.Generic;
using LeetCode2;
namespace LeetCode2Test
{
    public class DiagonalSortTest
    {
        [Fact]
        public void TestName()
        {
        //Given
         var diagonal = new MatrixAlgorithms();
         
        /*
        public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
            
        var m = mat.Length;
        var n = mat.FirstOrDefault().Count();
        List<int> l = new List<int>();
        Console.WriteLine("here ");
        var newN = n +m-1;
        var mat1 = new int[m][];
        
        for(int i=0;i<m;i++)
        {
            mat1[i] = new int[newN];
            for(int j=0;j<newN;j++)
            {
                if(j-i>=0 && j-i<n)
                {
                    mat1[i][j] = mat[i][j-i];
                }
                else
                {
                    mat1[i][j] = Int32.MinValue;
                }
            }
        } 
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<newN;j++)
            {
                Console.Write(mat1[i][j] +" ");
            }
            Console.WriteLine();
        }
        
        
         var m1 = new int[1][];
            m1[0] = new int[1]{3};
            return m1;
    }
}
        */
        
        //When
        
        //Then
        }
       

    }
}