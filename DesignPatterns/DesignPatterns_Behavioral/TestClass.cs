 
namespace DesignPatterns_Behavioral
{
public abstract class A
    {
        private int b;
       public A(int b)
       {
            this.b=b;
       }
       public  void Test1method()
       {

       }
       public abstract void Test2Method();
    }
    public class B:A
    {
        public B(int c):base(c)
        {

        }
        new public  void Test1method()
        {
            base.Test1method();
        }
        public override void Test2Method()
        {
            throw new System.NotImplementedException();
        }
    }
}