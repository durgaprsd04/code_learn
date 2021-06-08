using System;
using System.Text;
namespace CSharp.Basics
{
    public abstract class AbstractClassTest
    {
        internal string name;
        public AbstractClassTest(string name)
        {
            this.name = name;
            Console.WriteLine("constructor of "+this);
        }
        public virtual  void PrintLine()
        {
            Console.WriteLine("hello form print line");
        }
        public override string ToString()
        {
            return "abstractclass";
        }
    }
    public class SolidClass : AbstractClassTest
    {
        public SolidClass(string name):base(name)
        {

        }
        public override void PrintLine()
        {
            Console.WriteLine("hello form print  in Solid "+base.name);;
        }
        public void PrintLine1()
        {
                base.PrintLine();
        }
        public override string ToString()
        {
            return "Solidclass";
        }

    }
    public class TestFuncAbstract
    {
        public void Testfunc2()
        {
            AbstractClassTest c1 = new SolidClass("weirdname");
            var c2 = new SolidClass("good name");
            c1.PrintLine();
            ((AbstractClassTest)c2).PrintLine();
        }
    }
}