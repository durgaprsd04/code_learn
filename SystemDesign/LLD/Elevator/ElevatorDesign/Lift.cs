using System;
using System.Threading.Tasks;
using System.Collections.Specialized;
namespace ElevatorDesign
{
    public class Lift:ILift
    {
        public async Task Move(int floor , int liftId)
        {
           Console.WriteLine($"Lift with id {liftId} moving to floor {floor}");
           await Task.Run( () => Task.Delay(1000));
        }

    }
}