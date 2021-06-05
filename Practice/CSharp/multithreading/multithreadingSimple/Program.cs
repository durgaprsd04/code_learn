using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
namespace multithreadingSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<Pellet> queue = new ConcurrentQueue<Pellet>();
            var list = new List<int>(){1,2,3};
            
            var battleShips = new List<BattleShip> (){
                new BattleShip(1,10),
                new BattleShip(2, 12),
                new BattleShip(3, 14)
            };
            var minHeap = new  SortedList<int, Pellet>[battleShips.Count];
            for(int i=0;i<minHeap.Length;i++)
                minHeap[i] = new SortedList<int, Pellet>();
            var clients = new List<Client>()
            {
                new Client(5, 3, 1),
                new Client(5, 3, 2),
                new Client(5, 3, 3)
            };

            Parallel.ForEach(list, i => {
                var pellet = clients[i-1].GetRandomPellet();
                if(clients[i-1].order[pellet.destination] == battleShips[pellet.destination].order)
                {
                    battleShips[pellet.destination].ChangeHealth(pellet);
                }
                else
                {
                    queue.Enqueue(pellet);
                    if(!minHeap[pellet.destination].ContainsKey(pellet.order))
                        minHeap[pellet.destination].Add(pellet.order, pellet);
                    else
                        minHeap[pellet.destination][pellet.order] = pellet;
                }
               // deque from and queue and check for min in order.
            });
            Console.WriteLine("Hello World!");
        }

    }
}
