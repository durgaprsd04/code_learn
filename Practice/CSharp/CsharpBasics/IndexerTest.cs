using System;
namespace CSharp
{            
    public class IndexerTest<T>
    {
       private T [] arr = new T[100];
        public T this[int i]
            {
                get { return arr[i]; }
                set { arr[i] = value; }
            }
    }
    
}