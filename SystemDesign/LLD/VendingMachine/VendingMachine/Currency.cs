using log4net;
using System.Collections.Generic;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class Currency : ICurrency
    {
        private ICurrencyType currencyType;
        private double value;
        public Currency(ICurrencyType currencyType, double value)
        {
            this.currencyType = currencyType;
            this.value = value;
        }
        public double GetValue()
        {
            return value;
        }
    }
}