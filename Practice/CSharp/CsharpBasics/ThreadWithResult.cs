using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class ThreadWithResultClass
    {
        public Task<long> GetSquare(int a)
        {
            var listOfNum = new List<int>();
            for(int i=1;i<=a;i++)
                listOfNum.Add(i);
            return Task.Run(  () => {long total =0; Parallel.ForEach( listOfNum, (item)=>
            {
                total=   item*item+total;
                if(a==5)
                throw new Exception("relly weird exception");
            });
            return total;});
        }
        public void MainTask(int n)
        {
            var tasks = new List<Task<long>>();
            for(int i =1;i<=n;i++)
            {
                tasks.Add(GetSquare(i));
            }
            try{
                    Task.WaitAll(tasks.ToArray());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception thrown e {e.Message} {e.GetType()}");
            }
            for (int ctr = 0 ; ctr < tasks.Count; ctr++) {
            if (tasks[ctr].Status == TaskStatus.Faulted)
               Console.WriteLine($"{ctr+1} with id {tasks[ctr].Id} does not exist ");
            else
               Console.WriteLine($"{tasks[ctr].Result} the  with id {tasks[ctr].Id} square of number '{ctr + 1}'");
            }
        }
    }
}
