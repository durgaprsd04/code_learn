using System;
using System.Linq;
using System.Text;
using System.Threading;
using CSharp.ThreadingConcepts;
using CSharp.GeneralTrivia;
using CSharp.OOP;
namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
          /*
         /// Delegate TeSt 
           
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
          

           
          Testclass tc = new Testclass();
           // Action a1 = ()=>Console.WriteLine("Hello from theother side "+a);
            //a="asshole";
             tc.TestMethod();
             tc.Dispose();
             
             //TestClass1 dt2 = new TestClass1();
             //dt2.CallStuf();
             //TestAnonymousDelegate tad = new TestAnonymousDelegate();
             //tad.TestAnonymous();
             //Testfunc tf = new Testfunc();
             //tf.FundTest("2",10); 
               
             EventTestExec ete = new EventTestExec();
             ete.TryEventTest();
              
            // TestExtMethod tem = new TestExtMethod();
             //tem.TestExtMethod1();
           
              var v = DemoCustomer.CreateNewCustomer();
               DemoCustomer.AddEvent(v);
             v.CustomerName="raju";
             v.PhoneNumber="(343)32313";
              TestRef tr = new TestRef();
             tr.Test();
              FuncAsArgument fs = new FuncAsArgument();
             Console.WriteLine($"a{10} b {40} result {fs.CallAdd(10,40)}");
             Testfunc tf = new Testfunc();
            tf.ActionTest("hello world");
             IndexerTest<int> it = new IndexerTest<int>();
            it[0] = 3;
            it[4]=4;
            Console.WriteLine($" t[0] {it[0]} it[4] {it[4]}");
             TestMethodInfo tmf = new TestMethodInfo();
            tmf.Main1();
             
            Test t = new Test();
            t.a=10;
            t.b=230;
            Console.WriteLine($"t.a{t.a} t.b {t.b}");
            
             
            var res = Activator.CreateInstance("CSharp","Test123");
            var res1 = ((Test123)res.Unwrap());
            res1.Method();
            
             
            var s = new Stack<int>();
            s.Push(3);
            s.Push(4);
            s.Push(1);
            Console.WriteLine($" s {s.Pop()}");
            Console.WriteLine($" s {s.Pop()}");
            Console.WriteLine($" s {s.Pop()}");
            
            //ThreadingSetup2 th = new ThreadingSetup2();
            //th.MainMethod();
            //th.Main1();
            //th.ThreadCalc(330);
            //th.ThreadCalcWithWait(30);
           // ThreadWithResultClass th = new ThreadWithResultClass();
           // th.MainTask(50);
           //ActionTest at = new ActionTest();
           //at.MainActionTest();
            ActivatorTest at = new ActivatorTest();
           at.ActivatorTestMethod1();
           var result  = Thread.GetDomain().FriendlyName;
           Console.WriteLine($"Friendly name from thread {result}");
           
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
        */
        /*
        var do1 = new DynamicObject();
        var v =do1.MainTest("hello world");
        v.Func1("hello world");
        var res = do1.ParseCsv("inputs/names.csv");
        dynamic n=null;
        foreach(var r in res)
        {
          n=r;
         if(( (IDictionary<String,object>)n).ContainsKey("phone") )
               Console.WriteLine($"name {r.Name},  age {r.age} phone {r.phone}");
          else 
          Console.WriteLine($"name {r.Name},  age {r.age}");
        }
         var v1 = ( (IDictionary<String,object>)n).Remove("Name") ;
         Console.WriteLine($" name {n.age}");
        }*/
        /*
        var v = new LinqTest();
        var n1 = v.SumUpto(10);
        Console.WriteLine($"Sum is {n1}");
        var l = v.GetAllInts(10);
        Console.WriteLine(string.Join(',', l.Select(x =>x).ToArray()));
        Console.WriteLine(string.Join(',', l.Where(x =>x%2==0).ToArray()));*
        */
        /*
        var v2 = new PassByRef();
        var v1 = new TestClasses(10,20);
        Console.WriteLine( v1.ToString());
        var v4 = v1;
        //v2.PassByRefTest1(v1);
                v2.PassByRefTest1(v4);
        Console.WriteLine( v1.ToString());
        Console.WriteLine( v4.ToString());

        var v3 = new TestStruct(3,4);
        Console.WriteLine( v3);
        v2.PassByRefTest1(v3);
        Console.WriteLine( v3);
        */
        /**
        IInterfaceTest i = new  Testclass();
        ((Testclass)i).TestMethod();
        */
        /*
        var v = new ReturMultipleTest();
        var d= v.ReturMultiple();
        Console.WriteLine($"d.val {d.val} d.flag {d.flag}");
        StringBuilder sb = new StringBuilder("adfs");
        sb.Append("he").Append(" is");
         Metronome1 m1 = new Metronome1();
*/

//         LinqTest t = new LinqTest();
        // var v1 = t.MovingSum(new List<float>(){3,4,4,5});
      //  var v1 = t.Fibonacci(10);
        // Console.WriteLine(string.Join(", ", v1.ToArray()));
  //      OrderOfInvocation of = new OrderOfInvocation(4);

    /*    static void ChangeReferenceType(Student std2)
{
    std2.StudentName = "Steve";
    std2.StudentName=null;
}

  Student std1 = new Student();
    std1.StudentName = "Bill";
    
    ChangeReferenceType(std1);

    Console.WriteLine(std1.StudentName);

*/

/*
    LinqPractise lp = new LinqPractise();
    var res = lp.Practise();
    foreach(var r in res)
    {
      Console.WriteLine(r);
    }
    var res1 = lp.GetPrime(200);
    Console.WriteLine(string.Join(", ", res1.ToArray()));
    

    var res2 = lp.GetPrimeEnum(200, lp.isPrime);
    Console.WriteLine(string.Join(", " , res2.ToArray()));
    */
    /*
    var testA = new TestA();
    var testB = new TestB();
    var testc = new TestB();

    LinqTest lt = new LinqTest();
    Console.WriteLine(lt.Test5().Sum());
    Console.WriteLine(string.Join(",",lt.Test5()));
    Console.WriteLine(testc);
    Console.WriteLine(string.Join(", ", lt.GetSequence(17)));
    */
    /*
    XMLPractise xML = new XMLPractise();
    xML.XMLTests();*/
    
    /*var w = new Worker();
    w.WorkerTask(100);
    */
    /*
    FuncAsArgument f  = new FuncAsArgument();

    var result = f.GetAllPrimeInts(f.IsPrime, Enumerable.Range(1,200));
    Console.WriteLine(string.Join(", ", result));
    */
    /*
    var stack = new System.Collections.Generic.Stack<int>();
    for(int i=0;i<10;i++)
    stack.Push(i);
    Console.WriteLine(string.Join(",", stack.Reverse().ToArray()));
    */
    //Threading1 t = new Threading1();
    //t.Main1();
    /*
    TaskRunTest t = new TaskRunTest();
    t.TestTask();
    PliqExample p = new PliqExample();
    p.PlinQCall();
    ClassicThreading ct  = new ClassicThreading();
    ct.ThreadCall();
    */
    /*
    ExceptionHandling eh = new ExceptionHandling();
    eh.TryWithoutCatch();
    */
    DestructorTest dt = new DestructorTest("hello");
    
  
    }

  }
}
