using System;

namespace CSharp.Basics
{
    interface IInterfaceTest
    {
        void TestMethod();
    }
    public class Testclass :IInterfaceTest, IDisposable
    {
        public Testclass()
        {
            Console.WriteLine("Constructor called");
        }
        ~Testclass()
        {
            Console.WriteLine("Destructor called");
            Dispose();
        }
        public void Dispose()
        {
            
        }
        
        void IInterfaceTest.TestMethod()
        {
            Console.WriteLine("Test method");
        }
        public void TestMethod()
        {
            
            Console.WriteLine("Test method in class ");
        }
    }
}
    