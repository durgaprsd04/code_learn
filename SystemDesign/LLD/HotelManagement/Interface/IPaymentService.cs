using System;

namespace HotelManagement.Interace
{
    public interface IPaymentService
    {
        bool RefundPayment(string creditCard);
        bool RecievePayment(IBooking booking);
    }
}