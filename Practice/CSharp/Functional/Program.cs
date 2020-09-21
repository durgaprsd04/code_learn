using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FuntionalTest1 f = new FuntionalTest1();
            var v1 = f.GetFuntionalTest1();
            Console.WriteLine("array contents "+string.Join(',', v1) );
            FuntionalTest2.TestAdaporFunctions();
            FuntionalTest2.TestDependents();
            
        }
    }
}
