using System;

namespace multithreading.interfaces
{
    public interface IHealthVisitor
    {
        public void Recieve(Pellet p);
        public void Visit(IBattleShip battleShip);
    }
}