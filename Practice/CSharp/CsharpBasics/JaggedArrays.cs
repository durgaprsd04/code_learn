using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public class JaggedArrayTest
    {
        public  char[][] ConvertToJagged(List<List<char>> l)
        {
            var jagged = new char [l.Count][];
            int i=0;
            foreach(var k in l)
            {
                var c = k.ToArray();
                jagged[i] = new char [k.Count];
                for(int j = 0; j< k.Count;j++)
                    jagged[i][j] = k[j];
                i++;
            }
            return jagged;
        }
    }
}
