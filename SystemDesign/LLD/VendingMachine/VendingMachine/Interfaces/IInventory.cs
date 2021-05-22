using System.Collections.Generic;

namespace VendingMachine.Interfaces
{
    public interface IInventory
    {
        public IInventory Refill(IEnumerable<IItemInventory> items);
        public IInventory Dispense(string id, IAmount amount, int count);

    }
}