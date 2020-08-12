using System;
using System.Collections.Generic;
namespace DesignPatterns
{
    public abstract class Room
    {
           
    }
    public abstract class House
    {
        
        public House()
        {
            this.AddRoom();
        }
        public abstract void AddRoom();
        public abstract void PrintRoomList();
        
    }
    public class BedRoom :Room
    {

    }
    public class Kitchen:Room
    {
        
    }
    public class Hall:Room
    {
        
    }
    public class Bathroom:Room
    {
        
    }
    
    public class RK_1:House
    {
        private List<Room> _listOfRooms=new List<Room>();
        public override void AddRoom()
        {
            _listOfRooms.Add(new Kitchen());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new BedRoom());
        }   
        public override void PrintRoomList()
        {
            foreach(Room room in _listOfRooms)
            {
                Console.Write(" 1rk"+room.ToString());
            }
        }     
    }

     public class BHK_3:House
    {
        private List<Room> _listOfRooms=new List<Room>();
        public override void AddRoom()
        {
            _listOfRooms.Add(new Kitchen());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new BedRoom());
            _listOfRooms.Add(new BedRoom());
            _listOfRooms.Add(new BedRoom());

        }   
        public override void PrintRoomList()
        {
            foreach(Room room in _listOfRooms)
            {
                Console.Write(" 3bhk"+room.ToString());
            }
        }     
    }
    public class HouseFactory{
public static House GetHouse(string type)
    {
        House house=null;
        switch (type)
            {
            case "1rk":
                house= new RK_1();
                break;
            case "2bhk":
                house= new BHK_2();
                break;
            case "3bhk":
                house= new BHK_3();
                break;
            default:
                throw new ArgumentException("type");
            }
            return house;
    }
    }
    
    public class BHK_2:House
    {
        private List<Room> _listOfRooms=new List<Room>();
        public override void AddRoom()
        {
            _listOfRooms.Add(new Kitchen());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new Bathroom());
            _listOfRooms.Add(new BedRoom());
            _listOfRooms.Add(new BedRoom());

        }   
        public override void PrintRoomList()
        {
            foreach(Room room in _listOfRooms)
            {
                Console.Write(" 2bhk"+room.ToString());
            }
        }     
    }
    public class MainRoom
    {
        House [] ListOfHouses = new House[3];
     public void TestMethod()
     {
        ListOfHouses[0] = HouseFactory.GetHouse("2bhk");
        ListOfHouses[1] = HouseFactory.GetHouse("3bhk");
        ListOfHouses[2] =HouseFactory.GetHouse("1rk");
        foreach(House house in ListOfHouses)
        {
            Console.WriteLine( house.ToString());
            house.PrintRoomList();
        }
     }
        
    }
   
}