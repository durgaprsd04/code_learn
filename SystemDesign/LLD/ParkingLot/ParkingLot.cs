using System;
using System.Linq;
using System.Collections.Generic;
using ParkingLot.Interface;
namespace ParkingLot
{
    public class ParkingLot : IParkingLot
    {
        private IEnumerable<IVehicle> parkedVehicleCollection = new List<IVehicle>();
        private int lotSize;
        public ParkingLot(int lotSize)
        {
            this.lotSize = lotSize;
        }
        public int GetFreeParkingSpots()
        {
            return lotSize - parkedVehicleCollection.Select(x => x.GetSize()).Sum();
        }

        public bool IsSpotAvailable(IVehicle vehicle)
        {
            return parkedVehicleCollection.Select(x => x.GetSize()).Sum()<lotSize;
        }

        public bool ParkVehicle(IVehicle vehicle)
        {
            if(this.GetFreeParkingSpots()< vehicle.GetSize())
                return false;
            else
                parkedVehicleCollection.Append(vehicle);
            return true;
        }
    }
}