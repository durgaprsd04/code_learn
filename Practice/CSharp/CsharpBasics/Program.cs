using System;
using System.Threading;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Delegate TeSt */
          /*
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
            EventTest et = new EventTest();
            et.OnChange+=(name)=>{Console.WriteLine("Subscriber "+name +"added.");};
            et.OnChange+=(name)=>{Console.WriteLine("SubScriber 2"+name+"added");};
            et.EventRaise("madhu");
            EventTestWithDelegate evd = new EventTestWithDelegate("valencia");
            evd.OnChange+=(name)=>{Console.WriteLine("Hello dude "+name);};
            evd.OnChange+=(name)=>{throw new Exception("this method is error prone");};
            evd.OnChange+=(name)=>{Console.WriteLine("Well done"+name);};
            evd.Raise();
            
          
          ListIndexer l = new ListIndexer();
          l.TestList();
          */

          /*
          Testclass tc = new Testclass();
           // Action a1 = ()=>Console.WriteLine("Hello from theother side "+a);
            //a="asshole";
             tc.TestMethod();
             tc.Dispose();
             */
             //TestClass1 dt2 = new TestClass1();
             //dt2.CallStuf();
             //TestAnonymousDelegate tad = new TestAnonymousDelegate();
             //tad.TestAnonymous();
             //Testfunc tf = new Testfunc();
             //tf.FundTest("2",10); 
              /*
             EventTestExec ete = new EventTestExec();
             ete.TryEventTest();
              */
            // TestExtMethod tem = new TestExtMethod();
             //tem.TestExtMethod1();
           
            /* var v = DemoCustomer.CreateNewCustomer();
               DemoCustomer.AddEvent(v);
             v.CustomerName="raju";
             v.PhoneNumber="(343)32313";*/
             /*TestRef tr = new TestRef();
             tr.Test();*/
             /*FuncAsArgument fs = new FuncAsArgument();
             Console.WriteLine($"a{10} b {40} result {fs.CallAdd(10,40)}");*/
            /*Testfunc tf = new Testfunc();
            tf.ActionTest("hello world");*/
            /*IndexerTest<int> it = new IndexerTest<int>();
            it[0] = 3;
            it[4]=4;
            Console.WriteLine($" t[0] {it[0]} it[4] {it[4]}");*/
            /*TestMethodInfo tmf = new TestMethodInfo();
            tmf.Main1();*/
            /*
            Test t = new Test();
            t.a=10;
            t.b=230;
            Console.WriteLine($"t.a{t.a} t.b {t.b}");
            */
            /*
            var res = Activator.CreateInstance("CSharp","Test123");
            var res1 = ((Test123)res.Unwrap());
            res1.Method();
            */
            /*
            var s = new Stack<int>();
            s.Push(3);
            s.Push(4);
            s.Push(1);
            Console.WriteLine($" s {s.Pop()}");
            Console.WriteLine($" s {s.Pop()}");
            Console.WriteLine($" s {s.Pop()}");
            */
            //ThreadingSetup2 th = new ThreadingSetup2();
            //th.MainMethod();
            //th.Main1();
            //th.ThreadCalc(330);
            //th.ThreadCalcWithWait(30);
           // ThreadWithResultClass th = new ThreadWithResultClass();
           // th.MainTask(50);
           //ActionTest at = new ActionTest();
           //at.MainActionTest();
           /*ActivatorTest at = new ActivatorTest();
           at.ActivatorTestMethod1();
           var result  = Thread.GetDomain().FriendlyName;
           Console.WriteLine($"Friendly name from thread {result}");
           */
           //DelegateTest3 t =new DelegateTest3();
          // t.Action1();
          //Taskcheck tc = new Taskcheck();
        //  tc.TaskRunTest(10);
        Metronome1 m1 = new Metronome1();
        Okay o = new Okay();
         metro1 m = new metro1(4,5);
        Console.WriteLine(o);
        m1.TestFunct(o);
        Console.WriteLine(o);
        Console.WriteLine("----------");
        
        Console.WriteLine(m);
         m1.TestFunct(m);
        Console.WriteLine(m);
        }

       
    }
}
