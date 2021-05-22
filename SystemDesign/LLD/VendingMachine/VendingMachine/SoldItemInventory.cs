using System.Collections.Generic;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class SoldItemInventory : ItemInventory
    {
        public SoldItemInventory(IItem item, int count):base(item, count)
        {

        }
        public override IItemInventory UpdateCount(int count)
        {
            base.count+=count;
            return this;
        }
    }
}