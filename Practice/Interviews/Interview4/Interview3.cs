using System;
using System.Linq;
namespace Interview4
{
    public class SearchinGrid
    {
        public bool HasElement(int [][] mat, int k)
        {
            int m =mat.Length-1;
            int n = mat.FirstOrDefault().Count()-1;
            int i=0;
            int j=n;
            if(mat[m][n]< k && mat[0][0] >k)
                return false; 
           var flag=false;
           while(i<=m && j>=0)
           {
               if(mat[i][j]==k)
               {
                   flag=true;
                   break;
               }
               else if(mat[i][j]>k)
                   j--;
               else
                   i++;
           }
           
           return flag; 
        }
    }
}