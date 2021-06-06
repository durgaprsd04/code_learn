using System;
using System.Collections.Generic;
namespace Pictionary
{
    public interface IServer :IClient
    {
        public void Register(string id, List<IClient> clientList) ;    
    }
}