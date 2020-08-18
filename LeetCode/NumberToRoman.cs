using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    class NumberToRoman
    {
      public string IntToRoman(int num) {
        var str=string.Empty;
        var backup =num;
        var dict = new Dictionary<int,char> {{1,'I'}, {5,'V'},{10,'X'}, {50,'L'}, {100,'C'}, {500,'D'}, {1000,'M' }};
        int multiplier =10;
        while(backup>0)
        {
          var reminder = backup%multiplier;
          backup = backup-reminder;
          multiplier*=10;
          //Console.WriteLine("Getting roman of "+reminder);
          if(reminder>0)
            str = GetNumber(reminder)+str;
        }
        return str;
    }
      public string GetNumber(int n)
      {
       //Console.WriteLine(n);
        var result=string.Empty;
        var dict = new Dictionary<int,char> {{1,'I'}, {5,'V'},{10,'X'}, {50,'L'}, {100,'C'}, {500,'D'}, {1000,'M' },{5000,'z'}};
         if(n<=1)
         {
           //Console.WriteLine("weird n "+n);
          return dict[1].ToString();
         }
        int [] keyArray = new [] {1,5,10,50,100,500,1000,5000};
             int i=1;
            for(;i<keyArray.Length;i++)
            {
              //Console.WriteLine((n)/keyArray[i]);
               if(n/keyArray[i]<=0)
                 break;
            }
           
          //Console.WriteLine("break flag "+keyArray[i]);
           if(n - keyArray[i]
                == -1 * (keyArray[i].ToString().StartsWith("5") ? keyArray[i - 1] : ((i - 2 >= 0) ? keyArray[i - 2] : keyArray[i - 1])))
           {
             var keyInQ=keyArray[i].ToString().StartsWith("5") ? keyArray[i - 1] : ((i - 2 >= 0) ? keyArray[i - 2] : keyArray[i - 1]);
             //Console.WriteLine("first "+ dict[keyInQ].ToString());
              result= dict[keyInQ].ToString()+dict[keyArray[i]].ToString();              
           }
           else if(n-keyArray[i-1]>0)
           {
             //Console.WriteLine("second "+dict[keyArray[i-1]].ToString());
              result= dict[keyArray[i-1]].ToString()+GetNumber(n-keyArray[i-1]);
              
           }
           else if(n-keyArray[i-1]<0)
           {
            ///Console.WriteLine("third {0} "+dict[keyArray[i-1]],n );
            result= GetNumber(n-keyArray[i-1])+dict[keyArray[i-1]].ToString();              
           }
           else
           {
              //Console.WriteLine("fourth "+ dict[keyArray[i-1]]);
              result= dict[keyArray[i-1]].ToString();
             
           }
           /// Console.WriteLine(result);
            return result;
      }
    }
}

 
