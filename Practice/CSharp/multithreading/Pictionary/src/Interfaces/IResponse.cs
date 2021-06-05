using System;

namespace Pictionary
{
    public interface IResponse
    {
        public string GetAnswer();
        public string GetSender();
        public string GetReciever();
    }
}