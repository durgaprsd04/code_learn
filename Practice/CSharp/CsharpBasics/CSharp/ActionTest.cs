using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class ActionTest
    {
        public void MainActionTest()
        {
            Action<string[], string [], char> op=null;
            op += AddStrings;
            op.Invoke( new string []{"a", "B","c"}, new string [] {"d", "E", "f"} , '&');
        }
        public void AddStrings(string []a , string [] b, char c)
        {
            var result =new StringBuilder();
            int i=0;
            foreach(string s in a)
            {
                var b1 = i<=b.Length?b[i]:a[i];
                result.Append(s).Append(c.ToString()).Append(b1); 
                i++;
            }
            Console.WriteLine($"total result {result}");
        }
    }
}