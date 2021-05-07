using System;
using HotelManagement.Interace;
namespace HotelManagement
{
    public class Hotel:IHotel
    {
        private IRoomCollection roomCollection;
        private readonly string hotelName;
        private readonly string address;
        public Hotel(IRoomCollection roomCollection, string hotelName, string address)
        {
            this.roomCollection = roomCollection;
            this.hotelName = hotelName;
            this.address =address;
        }
        
    }
}