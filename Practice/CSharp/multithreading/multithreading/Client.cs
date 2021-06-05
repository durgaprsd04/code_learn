using System;
using multithreading.interfaces;

namespace multithreading
{
    public class Client : IClient
    {
        private Random random = new Random();
        private int battleShipCount;
        private int bulletLimit;
        private readonly object balanceLock = new object();
        private int id;
 
        private int [] order ;
        private int orderIndex;
        IHealthVisitor healthVisitor;
        public Client(IHealthVisitor healthVisitor, int id, int battleShipCount, int bulletLimit)
        {
            this.id = id;
            this.battleShipCount =battleShipCount;
            this.bulletLimit = bulletLimit;
            this.healthVisitor = healthVisitor;
            order = new int[battleShipCount];
        }
        public void Shoot()
        {
            var pellet = GetRandomPellet();
            lock (balanceLock)
            {
                healthVisitor.Recieve(pellet);
            }
        }
        public Pellet GetRandomPellet()
        {
            var bulletSize = random.Next(bulletLimit);
            var battleShipId = random.Next(battleShipCount);
            //varorder = random.Next(5);
            //Console.WriteLine($"ship id {battleShipId} bulletSize {bulletSize}");
            //Console.ReadKey();
            if(orderIndex>=order.Length)
                orderIndex=0;
            var tempOrder =order[orderIndex++];
            return new Pellet(id, battleShipId, bulletSize, order[battleShipId]++);
        }
        
    }
}