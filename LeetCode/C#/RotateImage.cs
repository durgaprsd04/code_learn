using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            Transpose(matrix, n);
            ColumnSwap(matrix, n);
        }
        public void Transpose(int[][] matrix, int n)
        {
           List<int> rowList = new List<int>();
           List<int> colList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!(colList.Contains(i) && rowList.Contains(j)))
                    {
                        rowList.Add(i);
                        colList.Add(j);
                        var v = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = v;
                        Console.WriteLine($"here {i} {j}");
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void ColumnSwap(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    var v = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j  - 1];
                    matrix[i][n - j - 1] = v;
                }
            }

        }
    }
}