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
        public Client(IImage image, IServer server, bool isProvider, string id, bool IsWinner, int attemptCount)
        {
            this.localCopy = image;
            this.server = server;
            this.isProvider  = isProvider;
            this.id = id;
            this.IsWinner = IsWinner;
            this.attemptCount = attemptCount;
        }
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
            if(attemptCount>0)
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

        public void UpdateAsProvider()
        {
            this.isProvider=true;
        }
    }
}