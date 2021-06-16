using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;
namespace ElevatorDesign
{
    public class Elevators : IFloorManager
    {
        private ConcurrentDictionary<int, int> priorityDict =new ConcurrentDictionary<int, int>();
        private HashSet<int> isOccupied = new HashSet<int>();
        private ConcurrentDictionary<int,int> log = new ConcurrentDictionary<int, int>();
        private List<IElevator> elevators;
        private int floorCount;
        private int elevatorCount;
        public Elevators(int floorCount, List<IElevator> elevators)
        {
            this.floorCount = floorCount;
            this.elevators = elevators;
           
        }
        public Elevators(int floorCount, int elevatorCount)
        {
            this.floorCount = floorCount;
             this.elevatorCount = elevatorCount;
        }
         
        public void SimulatePushFromNthFloor(int sourceFloor, int targetFloor)
        {
            var liftInFloorN = elevators.Where(x => x.GetSourceDest().source==x.GetSourceDest().destination && x.GetSourceDest().source==sourceFloor).Min();
            if(liftInFloorN==null)
                liftInFloorN =elevators.Where( x => !isOccupied.Contains(x.GetId())).Min();
            liftInFloorN.PressButton(targetFloor);
            liftInFloorN.Move();
        }

        public void ExternalButtonPush(int floor, bool up)
        {
            PutLeastPriorityFloor(floor);
            // check log for any active lifts going that way
            var occupiedList = elevators.Where(x => isOccupied.Contains(x.GetId()) && x.IsGoingUp()==up);
            IElevator elevator;
            if(up)
                elevator =occupiedList.Where(x => x.GetSourceDest().source> floor).Min();
            else
                elevator =occupiedList.Where(x => x.GetSourceDest().source< floor).Min();
                
            if(elevator==null)
                elevator = elevators.Where(x => !isOccupied.Contains(x.GetId())).Min();
            isOccupied.Add(elevator.GetId());
            elevator.Move();
        }

        public int GetMostPriorityFloor(IElevator elevator)
        {
            var min = priorityDict.Keys.Min();
            int result = 0;
            while(result==0)
                priorityDict.TryRemove(min, out result);
            log.TryAdd(elevator.GetId(), min);
            isOccupied.Add(elevator.GetId());
            return result;
        }
        public void Notify(IElevator elevator)
        {
            isOccupied.Remove(elevator.GetId());
            int value =0;
            log.TryRemove(elevator.GetId(), out value);
        }
        public void PutLeastPriorityFloor(int floor)
        {
            var max=1;
            while(!priorityDict.TryAdd(max, floor))
            {
                max++;
            }
        }

        public void SetFloorList(List<IElevator> elevators)
        {
            this.elevators= elevators;
        }
    }
}