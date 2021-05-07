using System;
using HotelManagement.Interace;
namespace HotelManagement
{
    public class RoomFactory:IRoomFactory
    {
        public IRoom GetRoomType(string roomType)
        {
            switch(roomType)
            {
            case "Double":
                return new Room(Enums.RoomType.Double);
            case "KingSize":
                return new Room(Enums.RoomType.KingSize);
            default:
                return new Room(Enums.RoomType.Single);
            }
        }
    }
}