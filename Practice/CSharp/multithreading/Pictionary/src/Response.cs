using System;

namespace Pictionary
{
    public class Response : IResponse
   {
       private string sender;
       private string reciever;
    private string answer;
    public Response(string sender, string reciever, string answer)
    {
        this.sender = sender;
        this.reciever = reciever;
        this.answer = answer;
    }

        public string GetReciever()
        { 
            return reciever;
        }
        public string GetSender() 
        { 
            return sender;
        }

        public string GetAnswer()
        {
            return this.answer;
        }
    }
}