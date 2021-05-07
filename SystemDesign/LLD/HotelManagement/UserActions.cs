using System;
using System.Collections.Generic;
using HotelManagement.Enums;
using HotelManagement.Interace;
namespace HotelManagement
{
    public class UserAction : IUserAction
    {
        private IBookingHelper  bookingHelper;
        public UserAction(IBookingHelper bookingHelper)
        {
            this.bookingHelper = bookingHelper;
        }
        public bool CancelReservation(string id)
        {
            throw new NotImplementedException();
        }

        public IBooking CreateReservation(IHotel hotel,RoomType roomType, IEnumerable<IPerson> persons, DateTime startDate, DateTime endDate)
        {
            return new Booking(hotel, roomType,persons,startDate, endDate);
        }

        public IBooking ModifyReservation(string id)
        {
            var booking  = bookingHelper.GetBookingForId(id);
            return new Booking(booking);
        }
    }

}