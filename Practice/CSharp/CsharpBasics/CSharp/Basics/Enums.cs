using System;
using System.Linq;
using System.Collections.Generic;
namespace CSharp.Basics
{
    public enum Color
    {
        red,
        blue,
        green
    }
    public  class EnumsTest
    {
        private Dictionary<Color, int> dictCount = new Dictionary<Color,int>();
        public void EnumAsKeyTest(int n)
        {
            for(int i=0;i<10;i++)
            {
                var temp = (Color)(i%3);
                if(!dictCount.ContainsKey(temp))
                    dictCount.Add(temp,0);
                dictCount[temp]++;
            }
            Console.WriteLine(string.Join(", ", dictCount.Select(x => x.Key +":" +x.Value)));
        }
    }
}