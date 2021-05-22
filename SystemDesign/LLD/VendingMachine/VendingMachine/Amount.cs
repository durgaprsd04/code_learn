using log4net;
using System.Linq;
using System.Collections.Generic;
using VendingMachine.Interfaces;
namespace VendingMachine
{
    public class Amount : IAmount
    {
        private List<ICurrency> currencies;
        public Amount(List<ICurrency> currencies)
        {
            this.currencies = currencies;
        }
        public double GetValue()
        {
            return currencies.Select(x => x.GetValue()).Sum();
        }
    }
}