using System;
using ParkingLot.Interface;
namespace ParkingLot
{
    public abstract class Vehicle:IVehicle
    {
        private int size;
        public Vehicle(int size)
        {
            this.size = size;
        }

        public virtual int GetSize()
        {
            return size;
        }
    }
}