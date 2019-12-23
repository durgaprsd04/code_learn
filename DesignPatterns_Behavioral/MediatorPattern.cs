using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignPatterns_Behavioral
{
    public abstract class AbstractChatRoom
    {
        protected Dictionary<string, AbstractParticipant>_listofUsers = new Dictionary<string, AbstractParticipant>();
        public abstract void Send(string from, string to, string message);
        public abstract void Register(string name, AbstractParticipant abstractParticipant);
    }
    public class ChatRoom:AbstractChatRoom
    {
        public override void Send(string from, string to, string message)
        {
            if(_listofUsers[to]!=null)
            {
                _listofUsers[to].Recieve( from, message);
            }
        }
        public override void Register(string name, AbstractParticipant abstractParticipant)
        {
            _listofUsers.Add(name, abstractParticipant);
        }
    }
    public abstract class AbstractParticipant
    {
     
        protected string _name;
        protected AbstractChatRoom _chatroom;   
        public abstract void Recieve(string from, string message);
        public abstract void Send(string to, string message);
        public abstract void AddChatRoom(AbstractChatRoom chatroom);

    }
    public  class ParentParticipant :AbstractParticipant
    {
        public ParentParticipant(string name)
        {
            _name=name;
        }
        public override void AddChatRoom(AbstractChatRoom chatroom){}
        public override void Recieve(string from, string message){}
        public override void Send(string to, string message){}
    }
    public class Participant : ParentParticipant
    {
        public override void AddChatRoom(AbstractChatRoom chatroom)
        {
            _chatroom=chatroom;
        }
        public  Participant( string name)
        :base( name)
        {
            
        }
        public override void Recieve(string from, string message)
        {
            Console.WriteLine("Message {0} recieved from {1}",message, from);
        }
        public override void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }
    }
}