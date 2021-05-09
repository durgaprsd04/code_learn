using System;
using System.Reflection;
using System.Text;
namespace CSharp.OOP
{
    public class DestructorTest : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
        }
        private string name;
        
        public virtual void Dispose(bool code)
        {
            Dispose(code);
        }
        public DestructorTest(string name)
        {
            Console.WriteLine("Constructor Called");
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine($" Name is {name}");
        }
        ~DestructorTest()
        {
            Dispose(false);
            Console.WriteLine("Desstructor ccalled");
        }
    }
}