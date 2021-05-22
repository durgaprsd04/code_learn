using System;
namespace VendingMachine.Interfaces
{
    public interface IItemInventory
    {
        public IItemInventory Refill(int count);
        public  string GetItemId();
        public int GetCount();
        public double GetItemPrice();
        public IItem GetItem();
        public IItemInventory UpdateCount(int count); 
        
    }
}