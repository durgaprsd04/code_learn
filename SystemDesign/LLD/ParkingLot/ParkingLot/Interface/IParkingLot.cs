using ParkingLot.Enums;
using System;

namespace ParkingLot.Interface
{
    public interface IParkingLot
    {
        bool IsSpotAvailable(IVehicle vehicle);
        ErrorCodes ParkVehicle(IVehicle vehicle);
        ErrorCodes ParkVehicle(IVehicle vehicle, DateTime dateTime);
        ErrorCodes ParkVehicle(IVehicle vehicle, DateTime startTime, DateTime endTime);
        ErrorCodes ParkVehicle(IVehicle vehicle, DateTime startTime, DateTime endTime, double rate);
          
        (ErrorCodes code,double parkingCost) UnParkVehicle(IVehicle vehicle);
        int GetFreeParkingSpots();
    }
}