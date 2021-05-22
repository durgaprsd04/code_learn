using System;

namespace VendingMachine.Interfaces
{
    public interface IItem
    {
        public string GetId();
        public double GetPrice();
        public string GetName();
        public IItem ModifyPrice(double newPrice);
    }
}
