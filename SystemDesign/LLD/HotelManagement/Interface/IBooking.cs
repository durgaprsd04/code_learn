using System;

namespace HotelManagement.Interace
{
    public interface IBooking
    {
        string Id();
        bool IsActive();
        double GetBill(bool isCanceled);
    }    
}