using System;

namespace DesignPatterns_Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behavioural Patterns Implemenation");
            Console.WriteLine("Chain of Responsibility");
            Manager manager = new Manager();
            VP vp = new VP();
            AVP avp = new AVP();
            avp.SetManager(vp);
            manager.SetManager(avp);
            manager.ApproveSum(1000);
            manager.ApproveSum(11000);
            manager.ApproveSum(20000);
            manager.ApproveSum(10000434);
            Console.WriteLine("Command Pattern");
            Client client = new Client();
            client.Compute('+',3);
            client.Compute('-',5);
            client.Compute('/',4);
            client.Compute('*',1);
            client.Undo(4);
            client.Redo(3);
            Console.WriteLine("Current value"+client.currentValue());


        }
    }
}