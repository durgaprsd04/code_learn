using System.Collections.Generic;
using VendingMachine.Interfaces;
using log4net;
namespace VendingMachine
{
    public class InventoryCollection : IInventoryCollection
    {
        private Dictionary<string, IItemInventory>  inventory;
        private Dictionary<string, SoldItemInventory> soldItems;

        private Dictionary<string, double> soldItemPrice;
        private ILog logger;

        public InventoryCollection( Dictionary<string, IItemInventory> inventory , ILog logger)
        {
            this.inventory = inventory;
            this.logger = logger;
            soldItemPrice = new Dictionary<string, double>();
            soldItems = new Dictionary<string, SoldItemInventory>();
        }
        
        public IInventoryCollection Dispense(string id, IAmount amount, int count)
        {
            if(inventory.ContainsKey(id))
            {
                if(count >= inventory[id].GetCount())
                {
                    if(inventory[id].GetItemPrice() *count >=amount.GetValue())
                    {
                        inventory[id]= inventory[id].UpdateCount(count);
                        if(!soldItems.ContainsKey(id))
                            soldItems.Add(id, new SoldItemInventory(inventory[id].GetItem(),count));
                        else
                            soldItems[id].UpdateCount(count);
                        soldItemPrice.Add(id, count* inventory[id].GetItemPrice());
                    }
                    else
                        logger.Error($"Not enough money to dispense {count} items of price {count* inventory[id].GetItemPrice()}");
                }
                else
                    logger.Error("not enough item(s) to dispense");
            }
            else
                logger.Error("Item not present in machine");
            return this;
        }

        public IInventoryCollection Refill(IEnumerable<IItemInventory> items)
        {
            foreach(var item in items)
            {
                if(!inventory.ContainsKey(item.GetItemId()))
                    inventory.Add(item.GetItemId(),item);
                else
                    inventory[item.GetItemId()].Refill(item.GetCount());
            }
            return this;
        }
    }
}