using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignPatterns
{
    public class Shop
    {
        public VehicleBuilder Construct(VehicleBuilder builder)
        {
            builder.BuildFrame().BuildEngine().BuildWheels().BuildDoors()
            .SetVehicleSpecs().AddSeats().AddColor();
            return builder;
        }
    }

    public class VehicleSpecs
    {
        public int seats;
        public string color;
        public void AddColor(string color)
        {
            this.color = color;
        }
        public  void AddSeats(int seats)
        {
            this.seats=seats;
        }

    }
    public abstract class VehicleBuilder
    {
        //simple builder had only void returns.
        //fluent builder had builder returns.
        //has compositve building too.
        //
        protected PartList partList = new PartList();
        protected VehicleSpecs vehicleSpecs;
        public abstract void showPartList();
        public abstract VehicleBuilder BuildFrame();
        public abstract VehicleBuilder BuildEngine();
        public abstract VehicleBuilder BuildWheels();
        public abstract VehicleBuilder BuildDoors();
        public VehicleBuilder SetVehicleSpecs(){vehicleSpecs= new VehicleSpecs(); return this; }
        public abstract VehicleBuilder AddSeats();
        public abstract VehicleBuilder AddColor();
    }
    public  class ScooterBuilder:VehicleBuilder
        {           
            public override VehicleBuilder BuildFrame()
            {
                partList.Add("Scooty Frame Added");
                return this;
            }
            public override VehicleBuilder BuildEngine()
            {
                partList.Add("Small Engine added:150cc");
                 return this;
            }
            public override VehicleBuilder BuildWheels()
            {
                partList.Add("Two wheels added");
                 return this;
            }
            public override VehicleBuilder BuildDoors()
            {
                partList.Add("No Doors added");
                 return this;
            }
            public override void showPartList()
            {
               partList.Show();
                Console.WriteLine($"Has seats {vehicleSpecs.seats} and color {vehicleSpecs.color}");
                                
            }
            public  override   VehicleBuilder AddSeats()
            {
                vehicleSpecs.AddSeats(2);       
                return this;        
            }
            public override VehicleBuilder AddColor()
            {
                vehicleSpecs.AddColor("pink");
                return this;
            }
        }
    public  class AutoBuilder:VehicleBuilder
        {            
            public override VehicleBuilder BuildFrame()
            {
                partList.Add("Auto Frame Added");
                return this;
            }
            public override VehicleBuilder BuildEngine()
            {
                partList.Add("Medium Engine added:250cc");
                return this;
            }
            public override VehicleBuilder BuildWheels()
            {
                partList.Add("Three wheels added");
                return this;
            }
            public override VehicleBuilder BuildDoors()
            {
                partList.Add("Four Doors added");
                return this;
            }
            public override void showPartList()
            {
                partList.Show();
                Console.WriteLine($"Has seats {vehicleSpecs.seats} and color {vehicleSpecs.color}");
            }
            public override  VehicleBuilder AddSeats()
            {
                vehicleSpecs.AddSeats(3);       
                return this;        
            }
            public override VehicleBuilder AddColor()
            {
                vehicleSpecs.AddColor("black");
                return this;
            }
        }
    public  class CarBuilder:VehicleBuilder
        {           
            public override VehicleBuilder BuildFrame()
            {
                partList.Add("Car Frame Added");
                return this;
            }
            public override VehicleBuilder BuildEngine()
            {
                partList.Add("Large Engine added:800cc");
                return this;
            }
            public override VehicleBuilder BuildWheels()
            {
                partList.Add("Four wheels added");
                return this;
            }
            public override VehicleBuilder BuildDoors()
            {
                partList.Add("Four Doors added");
                return this;
            }
            public override void showPartList()
            {
                partList.Show();
                Console.WriteLine($"Has seats {vehicleSpecs.seats} and color {vehicleSpecs.color}");
            }
            public override   VehicleBuilder AddSeats()
            {
                vehicleSpecs.AddSeats(4);       
                return this;        
            }
            public override   VehicleBuilder AddColor()
            {
                vehicleSpecs.AddColor("red");
                return this;
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