using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ElevatorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var lift = new Lift();
            Elevators floorManager = new Elevators(12, 3);
            
            var listOfElevators = new List<IElevator>()
            {
                new Elevator(4,lift,floorManager, 12, 0 ),
                new Elevator(2,lift,floorManager, 12, 0 ),
                new Elevator(3,lift,floorManager, 12, 0 )
            };
            floorManager.SetFloorList(listOfElevators);
             
             var floorList = new List<int>(){1,2,6,8,9};
             Parallel.ForEach(floorList, floor => floorManager.ExternalButtonPush(floor, true));
            //floorManager.ExternalButtonPush(5, true);
          //  floorManager.ExternalButtonPush(7, true);
            //floorManager.ExternalButtonPush(1, true);

           
        }
    }
}
