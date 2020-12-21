using System;

namespace CSharp
{
    public class TestRef
    {
        public void Test()
        {
            var c = "helloworld";
            var b = c;
            var b1 = "is this new";
            b=b1;
            Test1 d = new Test1();
            d.a=10;
            var e = d;
            e.a=11;
            Console.WriteLine($"c : {c} b : {b} b {b1}" );
            Console.WriteLine($"d.a : {d.a} e.a : {e.a}" );
        }
        
    }
    public class Test1{
        public int a;
            
        }
}