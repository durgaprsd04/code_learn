using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.ThreadingConcepts
{
    public class PliqExample
    {
        public void PlinQCall()
        {
            var result = Enumerable.Range(1,10000);
            var evens  = result.AsParallel().Where(x => x%3==0);
            foreach(var even in evens)
                Console.Write(even+" ");
        }   
    }
}