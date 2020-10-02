using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class EquivalentDomino
    {
       public int NumEquivDominoPairs(int[][] dominoes)
       {
         int [][] tag = new int [10][];
         for(int i=0;i<10;i++)
           tag[i] = new int[10] {0,0,0,0,0,0,0,0,0,0};
         int count=0;
         var len = dominoes.Length;
         for(int i=0;i<len;i++)
         {
            tag[dominoes[i][0]][dominoes[i][1]]++;
            if(dominoes[i][0]!=dominoes[i][1])
              tag[dominoes[i][1]][dominoes[i][0]]++;

         }
         /*
         foreach( var t in tag)
         {
           foreach(var t1 in t)
             Console.Write(t1+" ");
           Console.WriteLine();
         }*/
        for(int i=0;i<10;i++)
         {
           for(int j=0;j<10;j++)
           {
             if(tag[i][j]>1)
               count+= tag[i][j]*(tag[i][j]-1)/2;
             tag[j][i]=0;
           }
         }

         return count;
      }
    }
}
