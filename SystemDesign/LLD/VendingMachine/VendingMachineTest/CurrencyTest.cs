using System;
using Xunit;
using VendingMachine;
using System.Collections.Generic;
namespace VendingMachineTest
{
    public class CurrencyTest
    {
        [Fact]
        public void Currency_GetValue_Test1()
        {
            var currency = new VendingMachine.Currency(new Coin(), 5);
            Assert.Equal(5, currency.GetValue());
        }
    }
}
