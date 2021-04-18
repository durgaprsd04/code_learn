using System;
namespace CSharp
{            
    public delegate int testdelegate1(int x);
    public delegate string testdelegate2(string a);

    public class DelegateTest2 
    {
        public static int Square(int x)
        {
            return x*x;
        }
        public static int Cube(int x)
        {
            return x*x*x;
        }
        public int Times3(int x)
        {
            return 3*x;
        }
       
    }
    public class Testfunc
    {
        private Action<int> p;

        public Testfunc(Action<int> p)
        {
            this.p = p;
        }

        public Testfunc()
        {
        }

        public int FuncTest(Func<string,string, int> func, string a, string b)
        {
            return func(a, b);
        }
        public int func1(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        public void ActionTest(string a)
        {
            Action<string> act = (string s) => {Console.WriteLine($"string is {s}");};
            act(a);
        }

    }
}
