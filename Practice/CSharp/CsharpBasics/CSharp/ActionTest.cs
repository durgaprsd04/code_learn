using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class ActionTest
    {
       public void AddStrings(string []a , string [] b, char c,StringBuilder result )
        {
            int i=0;
            foreach(string s in a)
            {
                var b1 = i<=b.Length?b[i]:a[i];
                result.Append(s).Append(c.ToString()).Append(b1); 
                i++;
            }
        }
    }
}