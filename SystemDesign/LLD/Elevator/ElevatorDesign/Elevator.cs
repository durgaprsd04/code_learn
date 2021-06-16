using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ElevatorDesign
{
    public class Elevator :IElevator
    {
        IFloorManager floorManager; 
        ILift lift;
        private int id;
        private int maxFloorcount;
        private int currentFloor;
        private int targetFloor;
        public Elevator(int id, ILift lift, IFloorManager floorManager,  int maxFloorcount,int currentFloor)
        {
            this.id =id;
            this.lift = lift;
            this.floorManager = floorManager;
            this.currentFloor =currentFloor;
            this.maxFloorcount = maxFloorcount;
        }

        public int CompareTo(IElevator other)
        {
            return this.id-other.GetId();
        }

        public int GetId()
        {
            return id;
        }

        public (int source, int destination) GetSourceDest()
        {
            return (currentFloor, targetFloor);
        }

        public bool IsGoingUp()
        {
            return currentFloor< targetFloor;
        }

        public void Move()
        {
            targetFloor = floorManager.GetMostPriorityFloor(this);
            //calll api to Move to target floor
            Task.WaitAll( lift.Move(targetFloor, this.GetId()));
            currentFloor = targetFloor;
            floorManager.Notify(this);
        }

        public void PressButton(int floor)
        {
           floorManager.PutLeastPriorityFloor(floor);
        }

    }
}