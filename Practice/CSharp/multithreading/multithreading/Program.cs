using System;
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
            var client = new Client(healthVisitor, 1, battleShips.Count, 5);
            while(battleShips.Where( x=> x.IsSunk()).Count()!=battleShips.Count)
            {
                client.Shoot();
            }
        }
    }
}
