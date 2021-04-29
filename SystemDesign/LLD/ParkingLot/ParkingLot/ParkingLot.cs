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
            if(this.GetFreeParkingSpots()< vehicle.GetSize())
                return ErrorCodes.RanOutOfSPace;
            else
                if(parkedVehicleCollection.ContainsKey(vehicle.GetId()))
                    return ErrorCodes.VehicleAlreadyExists;
                else
                    parkedVehicleCollection.Add(vehicle.GetId(), vehicle);
            return ErrorCodes.Success;
        }
        public (ErrorCodes code,double parkingCost) UnParkVehicle(IVehicle vehicle)
        {
            double cost = 0;
            if(parkedVehicleCollection.ContainsKey(vehicle.GetId()))
            {
                var  item = (ParkedVehicle)parkedVehicleCollection[vehicle.GetId()];
                cost = item.GetParkingCost();
                return (ErrorCodes.Success, cost);
            }
            else
                return (ErrorCodes.VehicleNotFound, -1);
        }
    }
}