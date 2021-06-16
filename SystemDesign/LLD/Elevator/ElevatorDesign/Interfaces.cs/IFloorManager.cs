using System;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace ElevatorDesign
{
    public interface IFloorManager
        {
        public void SetFloorList(List<IElevator> elevators);
        public int GetMostPriorityFloor(IElevator elevator);
        public void PutLeastPriorityFloor(int floor);
        public void Notify(IElevator elevator);
        public void ExternalButtonPush(int floor, bool up);
    }
}