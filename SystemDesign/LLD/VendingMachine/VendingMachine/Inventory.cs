using log4net;
using System.Collections.Generic;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class Inventory : IInventory
    {
        private IInventoryCollection inventory; 
        private ILog logger;
        private Inventory(IInventoryCollection inventory, ILog logger)
        {
            this.inventory = inventory;
            this.logger = logger;
        }
        public IInventory Refill(IEnumerable<IItemInventory> items)
        {
           inventory = inventory.Refill(items);
           return this;
        }
        public IInventory Dispense(string id, IAmount amount, int count)
        {
            inventory = inventory.Dispense(id, amount, count);
            return this;
        }
    }
}