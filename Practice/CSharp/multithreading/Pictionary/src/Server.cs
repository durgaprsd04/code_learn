using System;
using System.Collections.Generic;
namespace Pictionary
{
    public class Server : IServer
    {
        IImage currentImage;
        private string winnerId;
        private Dictionary<string , IClient>  clients ;
        private string providerIndex;
        public void RecieveImage(IImage image)
        {
            currentImage = image;
        }
        public void RecieveResponse(IResponse response)
        {
            if(response.GetSender()==providerIndex)
            {
                if(response.GetAnswer()=="Success")
                {
                    winnerId = response.GetReciever();
                    EndGame();
                }
                SendResponse(response);
            }
            else
            {
                if(response.GetReciever()==providerIndex)
                {
                    SendResponse( response);
                }
            }
        }
        public void EndGame()
        {
            
        }
        public string GetId()
        {
            throw new NotImplementedException();
        }
        public Server(IImage image, string providerIndex, List<IClient> clientList)
        {
            this.currentImage = image;
            this.providerIndex = providerIndex;
            foreach(var client in clientList)
            {
                clients.Add(client.GetId(), client);
            }
        }

        public void SendImage()
        {
            clients[providerIndex].RecieveImage(currentImage);
        }
        public void SendResponse( IResponse response)
        {
            string index = response.GetReciever();
            clients[index].RecieveResponse(response);
        }
    }
}