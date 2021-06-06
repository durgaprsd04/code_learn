using System;
using System.Collections.Generic;
namespace Pictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10][];
            for(int i=0;i<10;i++)
                arr[i] = new int[10];
            var image = new Image(arr);
            //Console.WriteLine("Hello World!");
            var server  = new Server(image);
            var clients = new List<IClient>()
            {
                new Client(image, server, false, Guid.NewGuid().ToString(), false, 3),
                new Client(image, server, false, Guid.NewGuid().ToString(), false, 3),
                new Client(image, server, false, Guid.NewGuid().ToString(), false, 3)
            };

            server.Register(clients[1].GetId(), clients);
            clients[1].
        }
    }
}
