using System;
using System.Collections.Concurrent;
namespace multithreadingSimple
{
    public class BattleShip
    {
        public int id;
        public int Health;
        public bool isSunk;
        public int order;
        public BattleShip(int id, int health)
        {
            this.id = id;
            this.Health= health;
            this.isSunk=false;
        }
        public void ChangeHealth(Pellet pellet)
        {
            this.Health -= pellet.size;
            if(this.Health<0)
                isSunk=true;
            order++;
        }
    }
}