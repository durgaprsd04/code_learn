using System;

namespace Pictionary
{
    public class Client : IClient
    {
        IImage localCopy;
        IServer server;
        bool isProvider;
        string answer;
        string id;
        private bool IsWinner;
        int attemptCount;
        public void RecieveImage(IImage image)
        {
            localCopy.UpdateImage(image);
        }
        public string GetId()
        {
            return id;
        }
        public void SendImage()
        {
            if(isProvider)
                server.RecieveImage(localCopy);
        }

        public void SendResponse(IResponse response)
        {
            server.RecieveResponse(response);
        }
         public void RecieveResponse(IResponse response)
        {
            if(isProvider)
            {
                if(answer==response.GetAnswer())
                    SendResponse(new Response(id, response.GetReciever(), "success"));
                else
                    SendResponse(new Response(id, response.GetSender(), "Failure"));
            }
            else
            {
                if(response.GetAnswer()=="Failure")
                    attemptCount--;
                else
                    IsWinner=true;
            }
        }

        
    }
}