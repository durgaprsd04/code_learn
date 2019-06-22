using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignPatterns
{
    public class Shop
    {
        public VehicleBuilder Construct(VehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
            return builder;
        }
    }

    public abstract class VehicleBuilder
    {

        public abstract void showPartList();
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
    public  class ScooterBuilder:VehicleBuilder
        {
            private PartList partList = new PartList();
            public override void BuildFrame()
            {
                partList.Add("Scooty Frame Added");
            }
            public override void BuildEngine()
            {
                partList.Add("Small Engine added:150cc");
            }
            public override void BuildWheels()
            {
                partList.Add("Two wheels added");
            }
            public override void BuildDoors()
            {
                partList.Add("No Doors added");
            }
            public override void showPartList()
            {
                partList.Show();
            }
        }
    public  class AutoBuilder:VehicleBuilder
        {
            public PartList partList = new PartList();
            public override void BuildFrame()
            {
                partList.Add("Auto Frame Added");
            }
            public override void BuildEngine()
            {
                partList.Add("Medium Engine added:250cc");
            }
            public override void BuildWheels()
            {
                partList.Add("Three wheels added");
            }
            public override void BuildDoors()
            {
                partList.Add("Four Doors added");
            }
            public override void showPartList()
            {
                partList.Show();
            }
        }
    public  class CarBuilder:VehicleBuilder
        {
            public PartList partList = new PartList();
            public override void BuildFrame()
            {
                partList.Add("Car Frame Added");
            }
            public override void BuildEngine()
            {
                partList.Add("Large Engine added:800cc");
            }
            public override void BuildWheels()
            {
                partList.Add("Four wheels added");
            }
            public override void BuildDoors()
            {
                partList.Add("Four Doors added");
            }
            public override void showPartList()
            {
                partList.Show();
            }
        }
    public class PartList
    {   
        private List<string> _parts = new List<string>();
        public void Add(string partName)
        {
            _parts.Add(partName);
        }
        public void Show()
        {
            Console.WriteLine("Parts added "+String.Join(", ", _parts.ToArray()));
        }
    }
    public class MainShop
    {
        public void TestMethod()
        {
            VehicleBuilder vehicleBuilder;
            vehicleBuilder = new ScooterBuilder();
            Shop shop = new Shop();
            
            var t= shop.Construct(vehicleBuilder);
            t.showPartList();
            vehicleBuilder = new AutoBuilder();
             t= shop.Construct(vehicleBuilder);
            t.showPartList();
            vehicleBuilder = new CarBuilder();
             t= shop.Construct(vehicleBuilder);
            t.showPartList();

        }
    }
    
        

}