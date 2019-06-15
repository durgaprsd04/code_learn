using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Delegate TeSt */
            Console.WriteLine("Test delegate");
            DelegateTest d1 = new DelegateTest();
            testdelegate t1 = d1.test1;
            t1("Simon");
            testdelegate t2 = d1.test2;
            t2("robin");
            testdelegate t3 = (name)=>{Console.WriteLine("A warm welcome "+name);};
            t3("Jacob");
            testdelegate t4 = t3+t1;
            t4("daddy");
            Console.WriteLine(t4.GetInvocationList().GetLength(0));
            Action<string> t5 =(name1)=>{Console.WriteLine(name1);};
            var arg="vegaman";
            var c=test_closure(arg);
            c();
            /*Action test */
            EventTest et = new EventTest();
            et.OnChange+=(name)=>{Console.WriteLine("Subscriber "+name +"added.");};
            et.OnChange+=(name)=>{Console.WriteLine("SubScriber 2"+name+"added");};
            et.EventRaise("madhu");
        }

        static Action test_closure(string a)
        {
            Action a1 = ()=>Console.WriteLine("Hello from theother side "+a);
            //a="asshole";
            return a1;
        }
    }
}
