using System;
using HotelManagement.Enums;
using System.Collections.Generic;
namespace HotelManagement.Interace
{
    public interface IUserAction
    {
        IBooking CreateReservation(IHotel hotel, RoomType roomType,IEnumerable<IPerson> persons, DateTime startDate, DateTime endDate);
        bool CancelReservation(string id);
        IBooking ModifyReservation(string id);
    }
}
