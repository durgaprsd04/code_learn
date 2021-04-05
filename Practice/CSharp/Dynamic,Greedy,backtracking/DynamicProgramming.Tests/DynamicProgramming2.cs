using System;
using Xunit;
using Dynamic_Greedy_backtracking;

namespace DynamicProgramming.Tests
{
    public class UnitTest1
    {
        private static DynamicProgramming2 dp  = new DynamicProgramming2();
        [Fact]
        public void GetLongestSubSequenceWithDifference1_Test1()
        {
            var data =new int []{10, 9, 4, 5, 4, 8, 6};
            var result = dp.GetLongestSubSequenceWithDifference1(data);
            Assert.Equal(3,result);
        }
        [Fact]
        public void GetLongestSubSequenceWithDifference1_Test2()
        {
            var data = new int []{1, 2, 3, 2, 3, 7, 2, 1};
            var result = dp.GetLongestSubSequenceWithDifference1(data);
            Assert.Equal(7,result);
        }
        
    }
}
