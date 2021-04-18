using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.GeneralTrivia
{
    public class ExceptionHandling
    {
        public void TryWithoutCatch()
        {
             try{
                Console.WriteLine("going to throw exception");
                throw new Exception("Another weird Exception");
            }
            finally
            {
                Console.WriteLine("Throw test finally");
            }
        }
    }
}

