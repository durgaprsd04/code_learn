using multithreading.interfaces;
using System;
namespace multithreading
{
    public class HealthVisitor : IHealthVisitor
    {
        private MinHeap<Pellet> [] minOrderPerShip;
        private int [] minValues; 
        Pellet pellet;
        private  IBattleShip [] battleShips;
        public HealthVisitor(IBattleShip[] battleShips )
        {
            this.battleShips = battleShips;
            minOrderPerShip  = new   MinHeap<Pellet>[battleShips.Length];
            for(int i=0;i< battleShips.Length;i++)
                minOrderPerShip[i] = new MinHeap<Pellet>();
            minValues = new int[battleShips.Length]; 
        }
        public void Recieve(Pellet pellet)
        {
            if(pellet!=null)
            {
                minOrderPerShip[pellet.source].Add(pellet);
                this.pellet = pellet;
                Visit(battleShips[pellet.source]);
            }
        }
        public void Visit(IBattleShip battleShip)
        {
            
            if(PelletsAreInOrder(pellet.source))
            {
                var temp = minOrderPerShip[pellet.source].GetList();
                var max= pellet.order;
                var temp1 =minOrderPerShip[pellet.source].RemoveMin(false);
                while(temp1 !=null && temp1.order == minValues[pellet.source])
                {
                    var result = minOrderPerShip[pellet.source].RemoveMin(true);
                    Console.WriteLine($"Reducing health by {result} for ship with shipid {result.source} details =>{battleShip}");
                    battleShip.ReduceHealth(result);

                    if(result.order> max)
                        max=result.order;
                    minValues[pellet.source]++;
                }
                minOrderPerShip[pellet.source].Clear();
                Console.WriteLine($"Health of ship with shipId {pellet.source} "+battleShip);
            }
        }
        private bool PelletsAreInOrder(int id)
        {
            //Console.WriteLine($"Pellet p added {pellet}");
            //Console.ReadKey();

            return minOrderPerShip[id].RemoveMin(false).order == minValues[id];
        }
    }
}