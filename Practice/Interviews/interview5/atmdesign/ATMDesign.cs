using System;
using System.Collections.Generic;
using System.Linq;
namespace interview5
{
    public class Denomination :IDenomination
    {
        private readonly string key;
        private readonly int value;
        public Denomination(string key , int value)
        {
            this.key = key;
            this.value = value;
        }

        public int GetValue() => value;

        public string GetKey() => key;
    }

    public class ATMDesign : IATMDesign
    {
        private readonly IList<IDenomination> supportedDenomination;
        private readonly Dictionary<string, int> currencyCount;
        public ATMDesign(IList<IDenomination> supportedDenomination, Dictionary<string, int> currencyCount)
        {
            this.supportedDenomination  = supportedDenomination;
            this.currencyCount  = currencyCount;
            supportedDenomination.OrderByDescending(x => ((Denomination)x).GetValue());
        }

        public Dictionary<string, int> CurrencyCount => currencyCount;

        //public IList<IDenomination> SupportedDenomination => supportedDenomination;

        public IATMDesign Dispense(int amount)
        {
            //var denominations = (Denomination)
            int i=0;
            var result = new Dictionary<string,int>();
            var dict =  new Dictionary<string,int>( currencyCount);
            while(amount>0 && i< supportedDenomination.Count())
            {
                if(amount>=supportedDenomination[i].GetValue())
                {
                    var val = amount/supportedDenomination[i].GetValue();
                    if(val < currencyCount[supportedDenomination[i].GetKey()])
                    {                        
                        dict[supportedDenomination[i].GetKey()] = currencyCount[supportedDenomination[i].GetKey()] - val;    
                        amount = amount - val*supportedDenomination[i].GetValue();                    
                    }
                }
                i++;
            }
            return new ATMDesign(supportedDenomination, dict);
        }

        public IATMDesign FillAtm(IList<IDenomination> denominations, Dictionary<string, int> refill)
        {
            var dict  = new Dictionary<string,int>(currencyCount);
            foreach(var key in refill.Keys)
            {
                if(dict.ContainsKey(key))
                    dict[key]+=refill[key];
                else
                    dict.Add(key, refill[key]);
            }
            return new ATMDesign(denominations, dict);
        }
    }
}