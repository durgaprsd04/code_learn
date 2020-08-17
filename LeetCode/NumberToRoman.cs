using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class NumberToRoman
    {
      public string IntToRoman(int num) {
        var backup =num;
        var dict = new Dictionary<int,char> {1:'I', 5:'V',10:'X', 50:'L', 100:'C', 500:'D', 1000:'M' };
        int multiplier =10;
        while(backup>0)
        {
          var reminder = backup%multiplier;

        }
    }
      public string GetNumber(int n)
      {
            var dict = new Dictionary<int,char> {1:'I', 5:'V',10:'X', 50:'L', 100:'C', 500:'D', 1000:'M' };
            int i;
            for(i =0;i<dict.Count;i++)
            {
               if(n/dict[i])<0)
                 break;
            }
            //i or i-1
            if(dict[i]-n)<2*dict[i-1])
              return max
      }
    }
}

 
