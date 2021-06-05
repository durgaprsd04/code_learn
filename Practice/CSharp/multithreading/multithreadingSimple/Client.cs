using System;
using System.Collections.Concurrent;
namespace multithreadingSimple
{
    public class Client
    {
        private Random random;
        private int sizeLimit;
        private int shipLimit;
        private int id;
        public int [] order;
        public Client(int sizeLimit, int shipLimit, int id)
        {
            this.id = id;
            this.sizeLimit = sizeLimit;
            this.shipLimit = shipLimit;
            order = new int [shipLimit];

        }
        public Pellet GetRandomPellet()
        {
            var shipId = random.Next(shipLimit);
            var size = random.Next(sizeLimit);
            return new Pellet(this.id, shipId, size, order[shipId]++ );
        }
    }
}