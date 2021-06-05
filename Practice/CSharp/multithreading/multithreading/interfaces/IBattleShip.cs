using System;

namespace multithreading.interfaces
{
    public interface IBattleShip
    {
        public void ReduceHealth(Pellet pellet);
        public bool IsSunk();
    }
}