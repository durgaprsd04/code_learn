using System.Collections.Generic;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class ItemInventory : IItemInventory
    {
        internal IItem item;
        internal int count;
        public IItem GetItem()
        {
            return item;
        }
        public ItemInventory(IItem item, int count)
        {
            this.item = new Item(item);
            this.count = count;
        }
        public IItemInventory Refill(int count)
        {
            this.count += count;
            return this;
        }
        public string GetItemId()
        {
            return item.GetId();
        }
        public double GetItemPrice()
        {
            return item.GetPrice();
        }
        public int GetCount()
        {
            return count;
        }
        public virtual IItemInventory UpdateCount( int count)
        {
            this.count -=count;
            return this;
        }
        
    }
}