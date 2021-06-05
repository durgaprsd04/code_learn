using multithreading.interfaces;
using System;
namespace multithreading
{
    public class BattleShip : IBattleShip
    {
        private int health;
        private bool isSunk;
        public bool IsSunk()
        {
            return isSunk;
        }
        public BattleShip(int health)
        {
            this.health = health;
        }
        public void ReduceHealth(Pellet pellet)
        {
            if(!isSunk)
                health -=pellet.size;
            if(health<0)
                isSunk=true;
            //Console.WriteLine(this);
        }
        public override string ToString()
        {
            return  $"health :{health} status :"+(isSunk?"Not Alive": "Alive");
        }
    }
}