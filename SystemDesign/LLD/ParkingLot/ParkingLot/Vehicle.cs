using System;
using ParkingLot.Interface;
namespace ParkingLot
{
    public abstract class Vehicle:IVehicle
    {
        private int size;
        private string id;
        public Vehicle(string id,int size)
        {
            this.size = size;
            this.id = id;
        }

        public virtual string GetId()
        {
            return id;
        }

        public virtual int GetSize()
        {
            return size;
        }
    }
}