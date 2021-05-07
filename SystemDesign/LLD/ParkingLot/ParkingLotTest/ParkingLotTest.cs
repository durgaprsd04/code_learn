using System;
using Xunit;
using ParkingLot;
using ParkingLot.Enums;
namespace ParkingLotTest
{
    public class ParkingLotTest
    {
        [Fact]
        public void ParkVehicle_Test1()
        {
            var id = Guid.NewGuid().ToString();
            var car = new Car(4, id);
            var parkingLot = new ParkingLot.ParkingLot(10);
            var result = parkingLot.ParkVehicle(car, DateTime.Today + new TimeSpan(8,0,0), DateTime.Today + new TimeSpan(10,0,0),50);
            Assert.Equal(ErrorCodes.Success , result);
        }
        [Fact]
        public void ParkVehicle_Test2()
        {
            var id = Guid.NewGuid().ToString();
            var car = new Car(4, id);
            var parkingLot = new ParkingLot.ParkingLot(2);
            var result = parkingLot.ParkVehicle(car, DateTime.Today + new TimeSpan(8,0,0), DateTime.Today + new TimeSpan(10,0,0),50);
            Assert.Equal(ErrorCodes.RanOutOfSPace , result);
        }
        [Fact]
        public void ParkVehicle_Test3()
        {
            var id = Guid.NewGuid().ToString();
            var car = new Car(4, id);
            var parkingLot = new ParkingLot.ParkingLot(26);
            var result = parkingLot.ParkVehicle(car, DateTime.Today + new TimeSpan(8,0,0), DateTime.Today + new TimeSpan(10,0,0),50);
            Assert.Equal(22 , parkingLot.GetFreeParkingSpots());
        }
        [Fact]
        public void UnParkVehicle_Test2()
        {
            var id = Guid.NewGuid().ToString();
            var car = new Car(4, id);
            var parkingLot = new ParkingLot.ParkingLot(26);
            var result = parkingLot.ParkVehicle(car, DateTime.Today + new TimeSpan(8,0,0), DateTime.Today + new TimeSpan(10,0,0),50);
            var result1 = parkingLot.UnParkVehicle(car);
            Assert.Equal(100.0 , result1.parkingCost);
        }
        [Fact]
        public void ParkVehicle_CapacityTest_Test4()
        {
            var id = Guid.NewGuid().ToString();
            var car = new Car(4, id);
            var bike = new Bike(2,Guid.NewGuid().ToString());
            var parkingLot = new ParkingLot.ParkingLot(26);
            parkingLot.ParkVehicle(bike);
            var result = parkingLot.ParkVehicle(car, DateTime.Today + new TimeSpan(8,0,0), DateTime.Today + new TimeSpan(10,0,0),50);
            parkingLot.UnParkVehicle(car);
            Assert.Equal(24, parkingLot.GetFreeParkingSpots());
        }
    }
}
