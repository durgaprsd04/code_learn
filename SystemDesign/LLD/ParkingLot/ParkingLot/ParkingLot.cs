using System;
using System.Linq;
using System.Collections.Generic;
using ParkingLot.Interface;
using ParkingLot.Enums;
namespace ParkingLot
{
    public class ParkingLot : IParkingLot
    {
        private IDictionary<string, IVehicle> parkedVehicleCollection = new Dictionary<string, IVehicle>();
        private int lotSize;
        public ParkingLot(int lotSize)
        {
            this.lotSize = lotSize;
        }
        public int GetFreeParkingSpots()
        {
            return lotSize - parkedVehicleCollection.Select(x => x.Value.GetSize()).Sum();
        }

        public bool IsSpotAvailable(IVehicle vehicle)
        {
            return parkedVehicleCollection.Select(x => x.Value.GetSize()).Sum()<lotSize;
        }

        public ErrorCodes ParkVehicle(IVehicle vehicle)
        {
           return ParkVehicle(vehicle, DateTime.Now, DateTime.Now + new TimeSpan(0,ParkingRate.MinTimeSpanInMinutes,0), ParkingRate.VehicleRate[0]);
        }
        public ErrorCodes ParkVehicle(IVehicle vehicle, DateTime startTime)
        {
           return ParkVehicle(vehicle, startTime, DateTime.Now + new TimeSpan(0,ParkingRate.MinTimeSpanInMinutes,0), ParkingRate.VehicleRate[0]);
        }
        public ErrorCodes ParkVehicle(IVehicle vehicle, DateTime startTime, DateTime endTime)
        {
           return ParkVehicle(vehicle, startTime, endTime, ParkingRate.VehicleRate[0]);
        }
        public ErrorCodes ParkVehicle(IVehicle vehicle, DateTime startTime, DateTime endTime, double rate)
        {
             var parkedVehicle  = new ParkedVehicle(vehicle, startTime, endTime, rate);
            if(this.GetFreeParkingSpots()< vehicle.GetSize())
                return ErrorCodes.RanOutOfSPace;
            else
                if(parkedVehicleCollection.ContainsKey(vehicle.GetId()))
                    return ErrorCodes.VehicleAlreadyExists;
                else
                    parkedVehicleCollection.Add(vehicle.GetId(), parkedVehicle);
            return ErrorCodes.Success;
        }
        public (ErrorCodes code,double parkingCost) UnParkVehicle(IVehicle vehicle)
        {
            if(parkedVehicleCollection.ContainsKey(vehicle.GetId()))
            {
                if(parkedVehicleCollection[vehicle.GetId()] is ParkedVehicle)
                {
                    var  item = (ParkedVehicle)parkedVehicleCollection[vehicle.GetId()];
                    parkedVehicleCollection.Remove(vehicle.GetId());
                    return (ErrorCodes.Success, item.GetParkingCost());
                }
                else
                    return (ErrorCodes.UnknownVehicle, -1);
            }
            else
                return (ErrorCodes.VehicleNotFound, -1);
        }
    }
}