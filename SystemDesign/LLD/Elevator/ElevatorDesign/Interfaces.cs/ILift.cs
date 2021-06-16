using System;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace ElevatorDesign
{
    public interface ILift
    {
        public Task Move(int floor, int liftId);
    }
}