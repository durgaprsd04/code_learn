using System;
using System.Collections.Generic;
using System.Linq;
namespace Functional
{
    public class FuntionalTest1
    {
       
        public int [] GetFuntionalTest1()
        {
             Func<int,int> trip =x => x*3;
             var range = Enumerable.Range(1,3);
             return range.Select(trip).ToArray();
        }
       
    }
    public static class FuntionalTest2
    {
            public static IEnumerable<T> Where<T>
                (this IEnumerable<T> ts, Func<T, bool> predicate)
                {
                foreach (T t in ts)
                    if (predicate(t))
                        yield return t;
                }
        static Func<T2, T1, R> SwapArgs<T1, T2, R>(this Func<T1, T2, R> f)
=> (t2, t1) => f(t1, t2);
         public static void TestAdaporFunctions()
        {
            Func<int, int, int> divide = (x, y) => x / y;
            var v = divide(10, 2); // => 5
           var divideBy = divide.SwapArgs();
           var c1= divideBy(2, 10); // => 5
           Console.WriteLine($"v :{v} c1: {c1}" );
        }
        public static void TestDependents()
        {
            Func<int,bool> greaterThan = x => x>10;
           var res= greaterThan(3);
           Console.WriteLine("3 greater than 10 "+res);          
        }
    }
    
}

