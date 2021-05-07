using System;
using System.Collections.Generic;
using HotelManagement.Interace;
using HotelManagement.Enums;
namespace HotelManagement
{
    public class Booking:IBooking
    {
        private readonly string id;
        private IHotel hotel;
        private RoomType roomType;
        private DateTime startDate;
        private DateTime endDate;
        IEnumerable<IPerson> persons ;
        public string Id()
        {
            return id;
        }

        public bool IsActive()
        {
            return DateTime.Now > startDate && DateTime.Now< endDate;
        }
        public double GetBill(bool isCanceled)
        {
            throw new NotImplementedException();
        }

        public Booking(IHotel hotel, RoomType roomType ,IEnumerable<IPerson> persons, DateTime startDate, DateTime endDate)
        {
            id = Guid.NewGuid().ToString();
            this.persons = persons;
            this.hotel = hotel;
            this.roomType = roomType;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public Booking(IBooking booking)
        {

        }
    }
}
