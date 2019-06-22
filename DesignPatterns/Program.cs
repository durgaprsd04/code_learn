using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Test");
            ConcreteFactory cf = new ConcreteFactory();
            Client client = new Client(cf);
            Console.WriteLine(client.ToString());
            Counter counter =  Counter.GetInstance(10);
            Console.WriteLine("counter count "+counter.ToString());
            counter.IncrCount();
            Console.WriteLine("Counter count is now "+counter.ToString());
            var c2 = Counter.GetInstance(4);
            Console.WriteLine("Counter count is now "+c2.ToString());
            MainShop mshop = new MainShop();
            mshop.TestMethod();
        }
    }
}
