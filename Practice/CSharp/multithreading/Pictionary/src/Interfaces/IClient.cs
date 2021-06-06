using System;

namespace Pictionary
{
    public interface IClient
    {
        public string GetId();
        public void UpdateAsProvider();
        public void SendImage();
        public void RecieveImage(IImage image);
        public void SendResponse(IResponse response);
        public void RecieveResponse(IResponse response);

    }   
}