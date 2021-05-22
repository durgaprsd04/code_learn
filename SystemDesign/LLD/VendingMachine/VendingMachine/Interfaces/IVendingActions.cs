using System.Collections.Generic;
namespace VendingMachine.Interfaces
{
    public interface IVendingMachineActions
    {
        public IVendingMachineActions Dispense(string id, IAmount amount, int count);
        public IVendingMachineActions Refill(IEnumerable<IItemInventory> items);
    }
}