using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class AtoiClass
    {
        public int MyAtoi(string s) 
        {
            
            var negativeFlag=false;
            long sum =0;
            var symbol =false;
            var isDigit=false;
            for(int i=0;i<s.Length;i++)
            {
                if(char.IsDigit(s[i]))
                {
                    isDigit=true;
                    sum= sum*10 + Convert.ToInt32(s[i].ToString());
                }
                else if(s[i]=='-')
                {
                    if(isDigit)
                    break;
                    if(symbol)
                    break;
                    symbol=true;
                    negativeFlag=true;  
                } 
                else if(s[i]=='+')      
                {
                    if(isDigit)
                    break;
                    if(symbol)
                    break;
                     symbol=true;
                     continue;
                }      
                else if(char.IsWhiteSpace(s[i]))
                {                   
                    continue; 
                }
                else break;                 
                if(sum<Int32.MinValue || sum>Int32.MaxValue)
                break;
            }
            if(negativeFlag)
                sum=sum*-1;
            sum= (sum>Int32.MaxValue)? Int32.MaxValue: sum;
            sum = (sum<Int32.MinValue)? Int32.MinValue: sum;
            return (int)sum;

        }
    }
}