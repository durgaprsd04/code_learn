using System;
using System.Collections.Generic;
using VendingMachine.Interfaces;
using log4net;
namespace VendingMachine
{
    public class VendingMachineActions : IVendingMachineActions
    {
        private IInventory inventory;
        private ILog logger;
        public VendingMachineActions(IInventory inventory, ILog logger)
        {
            this.inventory = inventory;
            this.logger = logger;
        }
        public IVendingMachineActions Dispense(string id, IAmount amount, int count)
        {
           inventory = inventory.Dispense(id, amount, count);
           return this;
        }

        public IVendingMachineActions Refill(IEnumerable<IItemInventory> items)
        {
            inventory = inventory.Refill(items);
            return this;
        }
    }
}