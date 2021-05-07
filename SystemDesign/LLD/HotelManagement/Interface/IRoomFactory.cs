using System;

namespace HotelManagement.Interace
{
    public interface IRoomFactory
    {
        IRoom GetRoomType(string roomType);
    } 
}