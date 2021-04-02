using System;
namespace CSharp
{    
    public class ReturMultipleTest
    {
        public (int val, bool flag) ReturMultiple()
        {
            return (10,true);
        }
    }
}
