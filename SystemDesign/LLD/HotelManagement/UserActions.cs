using System;
using System.Collections.Generic;
using HotelManagement.Enums;
using HotelManagement.Interace;
namespace HotelManagement
{
    public class UserAction : IUserAction
    {
        private IBookingHelper  bookingHelper;
        private IPaymentService paymentService;
        public UserAction(IBookingHelper bookingHelper)
        {
            this.bookingHelper = bookingHelper;
        }
        public (bool isCancelled, double billAmount) CancelReservation(string id)
        {
            var booking = bookingHelper.GetBookingForId(id);
            var billAmount = booking.GetBill(true);
            return (true, billAmount);
        }

        public IBooking CreateReservation(IHotel hotel,RoomType roomType, IEnumerable<IPerson> persons, DateTime startDate, DateTime endDate)
        {
            if(bookingHelper.IsRoomAvailable(hotel, roomType, startDate, endDate))
            {
                var booking = new Booking(hotel, roomType,persons,startDate, endDate);
                paymentService.RecievePayment(booking);
                bookingHelper.UpdateInventory(booking);
                return booking;
            }
            else
            {
                return null;
            }
        }

        public IBooking ModifyReservation(string id)
        {
            var booking  = bookingHelper.GetBookingForId(id);
            return new Booking(booking);
        }
    }

}