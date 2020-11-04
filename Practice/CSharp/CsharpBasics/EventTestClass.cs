using System;

namespace CSharp
{
    public delegate void tdelegate();
    public class EventTest1
    {
        public event tdelegate TestEvent1;
        public void Test()
        {
            TestEvent1+= ()=>{Console.WriteLine("Test1");};
            TestEvent1();
        }
    }
    public class EventTestExec
    {
        public void TryEventTest()
        {
            EventTest1 et =  new EventTest1();
            et.Test();
            et.TestEvent1+= ()=>{Console.WriteLine("Test2 modiifeid form there ");};
            et.Test();
        }
    }
}