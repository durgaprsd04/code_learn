using System;
using System.Text;
namespace CSharp
{
    public class ActivatorTest
    {
        public void ActivatorTestMethod1()
        {
            object obj = Activator.CreateInstance(typeof(StringBuilder));
            var v = (StringBuilder )obj;
            v.Append("a");
            v.Append("b");
            v.Append("c");
            Console.WriteLine($" The final result {v}");
        }
    }
}