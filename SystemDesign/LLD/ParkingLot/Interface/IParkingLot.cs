using System.Collections.Generic;

namespace ParkingLot.Interface
{
    public interface IParkingLot
    {
        bool IsSpotAvailable(IVehicle vehicle);
        bool ParkVehicle(IVehicle vehicle);
        int GetFreeParkingSpots();
    }
}