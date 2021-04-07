using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

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
        public bool IsPrime(int n)
        {
            var flag=true;
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {      
                  flag=false;
                    break;
                 }
            }
            return flag;
        }
        public IEnumerable<int> GetAllPrimeInts( Predicate<int> predicate, IEnumerable<int> list) 
        {
            return list.Where(x => !predicate(x));
        }
    }
}