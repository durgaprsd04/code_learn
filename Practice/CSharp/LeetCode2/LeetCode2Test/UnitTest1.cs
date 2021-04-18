using System;
using Xunit;
using System.Collections.Generic;
using LeetCode2;
namespace LeetCode2Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Time24 t = new Time24("23:59");
            var t1 = new Time24("00:00");
            var t2 = new Time24("06:40");
            List<Time24> l = new List<Time24>();
            l.Add(t);
            l.Add(t1);
            l.Add(t2);
            l.Sort();
            Assert.Equal("06:40", l[1].ToString());

        }
        [Fact]
        public void TestName()
        {
        //Given
        Time24 t = new Time24("23:59");
        var t1 = new Time24("00:00");
        //When
        
        //Then
        }
    }
}
