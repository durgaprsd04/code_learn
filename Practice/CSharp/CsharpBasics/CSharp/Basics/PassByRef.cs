using System;
using System.Text;
namespace CSharp.Basics
{
    public class PassByRef
    {
        public void PassByRefTest1(TestClasses t)
        {
            t.a=101;
            t.b=333;
            t=null;
        }
        public void PassByRefTest1(TestStruct t)
        {
            t.a=101;
            t.b=333;
        }
 
    }
    public struct TestStruct
    {
        public int a;
        public int b;
        public TestStruct(int a, int b)
        {
            this.a=a;
            this.b=b;
        }
        public override string ToString()
        {
            return $" struct a : {a} b : {b}";
        }
    }
    public class TestClasses
    {
        public int a;
        public int b;
        public TestClasses(int a, int b)
        {   
            this.a=a;
            this.b=b;
        }
        public override string ToString()
        {
            return $"a : {a} b : {b}";
        }
    }
}