using System;
using System.Threading;
namespace interview
{
    public class interview1
    {   

        public int WaitForFact(int n )
        {
            int res=0;
            var cworker = new Thread(() => Factorial(n, out res));
            cworker.Start();
            cworker.Join();
            return res;

        }
        public void Factorial(int n, out int res1)
        {
            var res =1;
            for(int i=1;i<=n;i++)
            res*=i;
            res1= res;
        }          
    }
}