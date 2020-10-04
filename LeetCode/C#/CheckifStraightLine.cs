using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class CheckIfStraightLine
    {
      public bool CheckStraightLine(int[][] coordinates)
      {
        if(coordinates.Length<=2)
          return true;
        var xAxis=false;
        var yAxis=false;
        var flag = true;
        var len = coordinates.Length;
        //y=mx+C
        var y1 = coordinates[0][1];
        var x1 = coordinates[0][0];
        var y2 = coordinates[1][1];
        var x2 = coordinates[1][0];
        double m=0, c=0;
        if(x1==x2 && x2==coordinates[2][0])
        {
          c = x1;
          xAxis=true;
        }
        else if(y1==y2 && y2==coordinates[2][0])
        {
            c = y1;
            yAxis =true;
        }
        else
        {
         m = (1.0*(y1-y2))/(x1-x2);
         c = (1.0*y1 - m*x1);
        }
        Console.WriteLine($"m {m} c {c}");
        for(int i=2;i<len;i++)
        {
         if(xAxis)
         {
            if(Math.Abs(coordinates[i][0]-c)<.0001)
            continue;
            else
            {
              flag=false;
              break;
            }
         }
         else if(yAxis)
         {
            if(Math.Abs(coordinates[i][1]-c)<.0001)
            continue;
             else
               {
                   flag=false;
                   break;
               }

         }
         else
         {
          if(Math.Abs( coordinates[i][1]-(coordinates[i][0]*m)- c) <.00001)
            continue;
           else
           {
            flag=false;
            break;
           }
          }
        }
        return flag;
      }
    }
}
