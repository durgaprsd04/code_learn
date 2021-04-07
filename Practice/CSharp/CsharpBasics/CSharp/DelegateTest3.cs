using System;

namespace CSharp
{
    public class DelegateTest3
    {
        public delegate void TestFunc(int a);
        public void Test1 (int a )
        {
            Console.WriteLine($"the number a {a}");
        }
        public void Test2(int b)
        {
            Console.WriteLine($"The number b {b}");
        }
        public void Action1()
        {
            DelegateTest3 t = new DelegateTest3();
            TestFunc t1 =t.Test1;
            TestFunc t2 = t.Test2;
            t1 +=t2;
            t2(40);
            t1(40);
        }
    }
}