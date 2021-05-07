using System;
using System.Collections.Generic;
using HotelManagement.Interace;
namespace HotelManagement
{
    public class RoomCollection : IRoomCollection
    {   
        private readonly int numberOfRooms;
        private readonly IRoomFactory roomFactory;
        
        private readonly Dictionary<int, IRoom> roomCollection = new Dictionary<int, IRoom>();
        
        public RoomCollection(IRoomFactory roomFactory,  int numberOfRooms, int singleRooms, int doubleRooms, int kingSizeRooms)
        {
            //todo class
            if(singleRooms+doubleRooms+kingSizeRooms>numberOfRooms)
                throw new NotImplementedException();

            this.roomFactory = roomFactory;
            this.numberOfRooms = numberOfRooms;
            for(int i=0;i<singleRooms;i++)
                roomCollection.Add(i+1, roomFactory.GetRoomType("Single"));
            
            for(int i=singleRooms;i<singleRooms+doubleRooms;i++)
                roomCollection.Add(i+1, roomFactory.GetRoomType("Double"));

            for(int i=singleRooms+doubleRooms;i<singleRooms+doubleRooms+kingSizeRooms;i++)
                roomCollection.Add(i+1, roomFactory.GetRoomType("KingSizeRoom"));

        }
        public RoomCollection(int numberOfRooms, IRoomFactory roomFactory):this(roomFactory,  numberOfRooms, 0,0,0)
        {

        }
        public int GetNumberOfRooms()
        {
            return numberOfRooms;
        }
    }
}