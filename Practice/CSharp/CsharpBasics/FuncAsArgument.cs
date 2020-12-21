using System;

namespace CSharp
{
    public class FuncAsArgument
    {
        public int TestAction(int a, int b, Func<int,int, int> op)
        {
            return op(a,b);
        }
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Sub(int a, int b)
        {
            return a-b;
        }
        public int CallSub(int a, int b)
        {
            return TestAction(a,b, Sub);
        }
         public int CallAdd(int a, int b)
        {
            return TestAction(a,b, Add);
        }
    }
}