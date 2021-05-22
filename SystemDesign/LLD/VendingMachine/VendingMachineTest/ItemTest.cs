using System;
using Xunit;
using VendingMachine;
using System.Collections.Generic;
namespace VendingMachineTest
{
    public class ItemTest
    {
        [Fact]
        public void Item_GetValue_Test1()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            Assert.Equal(id, item.GetId());
            Assert.Equal(10, item.GetPrice());
            Assert.Equal("Bingo", item.GetName());
        }
        [Fact]
        public void Item_UpdateValue_Test1()
        {
            var id =Guid.NewGuid().ToString();
            var item = new Item(id, "Bingo", 10);
            item.ModifyPrice(11);
            Assert.Equal(id, item.GetId());
            Assert.Equal(11, item.GetPrice());
            Assert.Equal("Bingo", item.GetName());
        }
    }   
}