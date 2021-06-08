using System;
using System.Text;
namespace CSharp.Basics
{
    public class BoxingUnboxing
    {
        public void BoxingUnboxingInt32()
        {
            Int32 num = 30;
            //boxing
            var obj = num;
            //unboxing
            Int16 num1 = (Int16)num;
            Console.WriteLine($"num {num} num1 {num}");
        }
    }
}