using System;
using Xunit;
using System.Collections.Generic;
using interview5;
namespace atmdesigntest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var list = new List<IDenomination>()
            {
                new Denomination("10",10),
                new Denomination("20",20),
                new Denomination("50",50)
            };
            var dict = new Dictionary<string, int>()
            {
                {"10",3},
                {"20",5},
                {"50",3}
            };
            var atmDesign = new ATMDesign(list,dict );
            var result = (ATMDesign)atmDesign.Dispense(100);
            Assert.Equal(1, result.CurrencyCount["50"]);
        }
    }
}
