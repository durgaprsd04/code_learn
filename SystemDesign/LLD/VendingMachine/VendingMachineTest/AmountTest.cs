using System;
using Xunit;
using VendingMachine;
using System.Collections.Generic;
namespace VendingMachineTest
{
    public class AmountTest
    {
        [Fact]
        public void Amount_GetValue_Test1()
        {
            var currencyList  = new List<VendingMachine.Interfaces.ICurrency>();
            currencyList.Add( new VendingMachine.Currency(new Coin(), 5));
            var amount = new Amount(currencyList);
            Assert.Equal(5,amount.GetValue());
        }
    }
}
