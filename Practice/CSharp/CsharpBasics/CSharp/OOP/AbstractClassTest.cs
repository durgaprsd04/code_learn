using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.OOP
{
    interface TestInterface
    {
        public void firstmethod();
    }
    public abstract class TestAbstract1 :TestInterface
    {
        private static Dictionary<string, int> dict= new Dictionary<string,int>();
        public TestAbstract1()
        {
            if(!dict.ContainsKey(this.GetType().Name))
                dict.Add(this.GetType().Name, 0);
            dict[this.GetType().Name]++;
        }

        public abstract void firstmethod();
        // public abstract void firstmethod()
        public  void secondMethod(){
            Console.WriteLine("hello world");
        }
        public override string ToString()
        {
             return string.Join(", ", dict.Select(x => x.Key + " : "+ x.Value ).ToArray());
        }

    }
    public class TestAAbstract:TestAbstract1
    {
        public TestAAbstract():base()
        {
            
        }

        public override void firstmethod()
        {
           Console.WriteLine("First method in TEST A");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class TestBAbstract:TestAbstract1
    {
        public TestBAbstract():base()
        {   
        }
        public override void firstmethod()
        {
           Console.WriteLine("First method in TEST B");
        }
         public override string ToString()
        {
            return base.ToString();
        }
    }

}