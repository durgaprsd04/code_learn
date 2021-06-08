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
        public Elevators(int floorCount, List<IElevator> elevators)
        {
            this.floorCount = floorCount;
            this.elevators = elevators;
        }

        public void ExternalButtonPush(int floor, bool up)
        {
            PutLeastPriorityFloor(floor);
            // check log for any active lifts going that way
            var nextElevator = elevators.Where( x => !isOccupied.Contains(x.GetId())).Min();
            nextElevator.Move(floor);
        }

        public int GetMostPriorityFloor(IElevator elevator)
        {
            var min = priorityDict.Keys.Min();
            int result = -1;
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
            var max  = priorityDict.Keys.Max()+1;
            priorityDict.TryAdd(max, floor);
        }
    }
}