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
            Console.WriteLine("Current value "+client.currentValue());
            Console.WriteLine("IteratorPattern");
            Collection cl = new Collection();
            cl[0]="a";
            cl[1]="b";
            cl[2]="c";
            Iterator it = new Iterator(cl);
            Console.WriteLine("Next "+it.Next().Name);
            Console.WriteLine("Current "+it.CurrentItem().Name);
            Console.WriteLine("First "+it.First().Name);
            it.Step=2;
            Console.WriteLine("Next with Step 2 "+it.Next().Name);
            Console.WriteLine("Interface pattern");
            ChatRoom chatRoom = new ChatRoom();
            AbstractParticipant participant1 = new Participant("John");
            AbstractParticipant participant2 = new Participant("Sam");
            AbstractParticipant participant3 = new Participant("Mark");
            participant1.AddChatRoom(chatRoom);
            participant2.AddChatRoom(chatRoom);
            participant3.AddChatRoom(chatRoom);
            chatRoom.Register("John",participant1);
            chatRoom.Register("Mark",participant3);    
            chatRoom.Register("Sam",participant2);
            participant1.Send("Sam", "hello Sam");
            participant1.Send("Mark", "hello Mark");
            participant2.Send("John", "hello John");
            participant2.Send("Mark", "hello Mark");
            participant3.Send("Sam", "hello Sam");
            participant3.Send("John", "hello John");

        }
    }
}