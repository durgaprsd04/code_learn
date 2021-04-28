using System;
using ParkingLot.Interface;
namespace ParkingLot
{
    public class ParkedVehicle:Vehicle
    {
        private DateTime startTime;
        private DateTime endTime;
        private double rate;
        public ParkedVehicle(int size):base(size)
        {

        }
        public double GetRate()
        {
            return (endTime- startTime).Hours*rate;
        }
    }
}