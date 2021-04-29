using ParkingLot.Enums;

namespace ParkingLot.Interface
{
    public interface IParkingLot
    {
        bool IsSpotAvailable(IVehicle vehicle);
        ErrorCodes ParkVehicle(IVehicle vehicle);
       (ErrorCodes code,double parkingCost) UnParkVehicle(IVehicle vehicle);
        int GetFreeParkingSpots();
    }
}