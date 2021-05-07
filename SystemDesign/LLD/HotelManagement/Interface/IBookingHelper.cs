using System;
using HotelManagement.Enums;
namespace HotelManagement.Interace
{
    public interface IBookingHelper
    {
        IBooking GetBookingForId(string id);
        bool IsRoomAvailable(IHotel hotel, RoomType roomType , DateTime startDate, DateTime endDate);
        IBooking UpdateInventory(IBooking booking);

    }
}