using System;
using ParkingLot.Interface;
namespace ParkingLot
{
    public class ParkedVehicle
    {

        private IVehicle vehicle;
        private DateTime startTime;
        private DateTime endTime;
        private double rate;
        public ParkedVehicle(IVehicle vehicle,  DateTime startTime, DateTime endTime, double rate)
        {
            this.vehicle = vehicle;
            this.startTime = startTime;
            this.endTime = endTime;
            this.rate = rate;
        }
        public double GetParkingCost()
        {
            return (endTime- startTime).Hours*rate;
        }
    }
}