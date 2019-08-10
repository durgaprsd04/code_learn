using System;
namespace DesignPatterns_Structural
{
    public interface Itest
    {
         void Test();
    }
    public class Atest:Itest
    {
        public void Test()
        {
            Console.WriteLine("test");
        }
    }
}