using System;
using Xunit;
using VendingMachine;
using System.Collections.Generic;
namespace VendingMachineTest
{
    public class ItemInventoryTest
    {
        [Fact]
        public void ItemInventory_GetValue_Test1()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            var ItemInventory = new ItemInventory(item, 5);
            Assert.Equal(id, ItemInventory.GetItemId());
            Assert.Equal(10, ItemInventory.GetItemPrice());
        }
        [Fact]
        public void ItemInventory_UpdateValue_Test1()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            var ItemInventory = new ItemInventory(item, 5);
            Assert.Equal(id, ItemInventory.GetItemId());
            Assert.Equal(10, ItemInventory.GetItemPrice());
            item.ModifyPrice(15);
            Assert.Equal(10, ItemInventory.GetItemPrice());
        }
        [Fact]
        public void ItemInventory_UpdateCount_Test1()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            var ItemInventory = new ItemInventory(item, 5);
            ItemInventory.UpdateCount(2);
            Assert.Equal(3, ItemInventory.GetCount());
        }
        [Fact]
        public void ItemInventory_UpdateCount_Test2()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            var ItemInventory = new ItemInventory(item, 5);
            var result = ItemInventory.UpdateCount(10);
            Assert.Equal(5, result.GetCount());
        }
        [Fact]
        public void ItemInventory_RefillCount_Test2()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            var ItemInventory = new ItemInventory(item, 5);
            var result = ItemInventory.Refill(10);
            Assert.Equal(15, result.GetCount());
        }
    }
}