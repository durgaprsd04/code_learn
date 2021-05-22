using System.Collections.Generic;
namespace VendingMachine.Interfaces
{
    public interface IInventoryCollection
    {
        public IInventoryCollection Refill(IEnumerable<IItemInventory> items);
        public IInventoryCollection Dispense(string id, IAmount amount, int count);
    }
}