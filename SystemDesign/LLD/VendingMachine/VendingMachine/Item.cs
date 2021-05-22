using System;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class Item : IItem
    {
        private string id;
        private string name;
        private double price;
        public Item(IItem item)
        {
            this.id = item.GetId();
            this.name = item.ToString();
            this.price = item.GetPrice();
        }
        public string GetName()
        {
            return name;
        }
        public Item(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string GetId()
        {
            return id;
        }

        public double GetPrice()
        {
            return price;
        }

        public IItem ModifyPrice(double newPrice)
        {
            this.price = newPrice;
            return this;
        }
    }
}