using System;
using System.Threading.Tasks;
using System.Linq;
using multithreading.interfaces;
using System.Collections.Generic;
namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var battleShips = new  List<IBattleShip>()
            {
               new BattleShip(10),
               new BattleShip(12),
                new BattleShip(14)
            };
            var healthVisitor = new HealthVisitor(battleShips.ToArray());
            var client = new Client[3];
            client[0] = new Client(healthVisitor, 1, battleShips.Count, 5);
            client[1] = new Client(healthVisitor, 2, battleShips.Count, 5);
            client[2] = new Client(healthVisitor, 3, battleShips.Count, 5);
            while(battleShips.Where( x=> x.IsSunk()).Count()!=battleShips.Count)
            {
                //Console.WriteLine("itrnation ");
                var temp =new List<int>(){0,1};
                Parallel.ForEach(temp , i  => client[i].Shoot());
                //client[0].Shoot();
            }
        }
    }
}
