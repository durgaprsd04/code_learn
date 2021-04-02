using System;
using System.Threading;
using System.Diagnostics;

namespace CSharp
{
    public class ThreadingSetup2
    {

        public void MainMethod()
        {
            Thread cThread = Thread.CurrentThread;
            Console.WriteLine($" thread name is{cThread.Name} and state is {cThread.ThreadState}");

            var workThread = new Thread(new ThreadStart(Work));
            Console.WriteLine($"Printing done worker thread state {workThread.ThreadState}");
            workThread.Start();
              var res = workThread.Join(1500);
             Console.WriteLine($"Printing done worker thread state {workThread.ThreadState}");
            Thread.Sleep(2000);
          
            Console.WriteLine($"Printing done worker thread state {workThread.ThreadState}  with res {res}");
        }
        public static void Work()
        {
           
            Thread.Sleep(1000);
            Console.WriteLine("hello world0");
        }
        public void Main1()
        {
            var b1 = new Broken();
            var bworker1 = new Thread(new ThreadStart(b1.Loop));
            var bworker2 = new Thread(new ThreadStart(b1.Loop));
            bworker1.Start();
            bworker2.Start();
            bworker1.Join();
            bworker2.Join();
            Console.WriteLine($"Bworder value {b1.dangerVariable}");
        }
        // C# atomic updation certain reads and writes on 32 bit integer is atomic but samne cannot be told to be 
        // true for double or ++/-- operators
        public void ThreadCalc(int radius)
        {
            var c1 = new Calculate(radius);
            var cWorker = new Thread(new ThreadStart(c1.CalculateArea));
            cWorker.Start();
            cWorker.Join();
            Console.WriteLine($" Area with radius {radius}  is {c1.result}");
        }
        public void ThreadCalcWithWait(int radius)
        {
            var c1 = new Calculate(radius);
            ThreadPool.QueueUserWorkItem(new WaitCallback(c1.CalculateArea));           
        }
    }
    public class Broken
    {
        public int maxLoop =4000000;
        public int dangerVariable =0;
        protected void UpdateMethod()
        {
            //Monitor.Enter(this);
                dangerVariable++;
              //  Monitor.Exit(this);
        }   
        public void Loop()
        {
            for(int i=0;i<maxLoop;i++)
            {
                lock(this)
                {
                    
                UpdateMethod(); 
                }
                //Console.Write(",");
            }
        }
    }
    public class Calculate
    {
        private double radius;
        public double result;
        
        public Calculate(double radius )
        {
            this.radius=radius;
        }
        public void CalculateArea(){
            result = Math.PI*radius*radius;
        }
          public void CalculateArea(object obj){
            result = Math.PI*radius*radius;
             Console.WriteLine($" Area with radius {radius}  is {result}");
        }
    }

}
