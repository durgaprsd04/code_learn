using System;
using System.Collections.Specialized;
namespace ElevatorDesign
{
    public interface IElevator :IComparable<IElevator>
    {
        public void PressButton(int floor);
        public void Move();
        public int GetId();

        public bool IsGoingUp();
        public (int source, int destination) GetSourceDest();
    }
}