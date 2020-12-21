using System;
namespace CSharp
{            
    delegate void testdelegate1();
    delegate void testdelegate2(string a);
    public class TestClass1 
    {
        public static void Print1()
        {
            Console.WriteLine("Print 1");
        }
        public static void Print2()
        {
            Console.WriteLine("print 2");
        }
        public void Print3()
        {
            Console.WriteLine("print 3");
        }
        public void CallStuf()
        {
            var t1 = new TestClass1();
            var t2 = new TestClass1();
        var t = new testdelegate1(TestClass1.Print1);
        t +=new testdelegate1( TestClass1.Print2);
        t+=new testdelegate1(t1.Print3);
        t();
        t-= new testdelegate1(t2.Print3);
        t();
        }

    }
    public class TestAnonymousDelegate
    {
            testdelegate1 t  = new testdelegate1(delegate {
                Console.WriteLine("Anonymous delegate");
            });
            testdelegate2 t1 = new testdelegate2(delegate (string gext){
                Console.WriteLine($"Anonymous delegate with arg{gext}");
            });
            public void TestAnonymous()
            {
                t();
                t1("gext");
            }
    }
    public class Testfunc
    {
        public void FundTest(string str2, int mul)
        {
            Func<string,int, int> myfunc=(str, mul) => int.Parse(str)*mul;
            Console.WriteLine($"Result {3+ myfunc(str2, mul)}");
        }
        public void ActionTest(string a)
        {
            Action<string> act = (string s) => {Console.WriteLine($"string is {s}");};
            act(a);
        }

    }
}
