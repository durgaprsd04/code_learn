using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public class JaggedArrayTest<T>
    {
        public  T[][] ConvertToJagged(List<List<T>> l)
        {
            var jagged = new T [l.Count][];
            int i=0;
            foreach(var k in l)
            {
                var c = k.ToArray();
                jagged[i] = new T [k.Count];
                for(int j = 0; j< k.Count;j++)
                    jagged[i][j] = k[j];
                i++;
            }
            return jagged;
        }
    }
}
