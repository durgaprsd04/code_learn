using System;

namespace CSharp.Basics
{
    public class OrderOfInvocationParent
    {
        private int a;
        public OrderOfInvocationParent()
        {
            Console.Write("another parent"+this.SamplePrint());
        }
        public OrderOfInvocationParent(int a)
        {
            this.a=a;
            Console.Write("another parent param"+SamplePrint());
        }
        public virtual string SamplePrint()
        {
            return "sampleprint";
        }
    }
    public class OrderOfInvocation : OrderOfInvocationParent
    {
        private int t=0;
        public OrderOfInvocation()
        {
            Console.WriteLine("Empty contstructor");
        }
        public OrderOfInvocation(int t):
        base(t)
        {
            Console.WriteLine("non empty contstructor");
            this.t =t;
        }
         public virtual string SamplePrint()
        {
            return "sampleprint2";
        }
    }
}
