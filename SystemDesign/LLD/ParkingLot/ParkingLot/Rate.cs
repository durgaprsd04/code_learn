using System;
using System.Collections.Generic;
namespace ParkingLot
{
    public static class ParkingRate
    {
        public static Dictionary<int, double> VehicleRate  = new Dictionary<int, double>(){
            {0,10},
            {2,10},
            {4, 50},
            {6,100}
        };
        public const int MinTimeSpanInMinutes =15;
    }
}