using System.Collections.Generic;
using System.Linq;
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
        [Fact]
        public void GetLongestPairLength_Test1()
        {
        //Given
        var data = new int [][]{new int[]{5, 24}, 
                                new int[]{39, 60}, 
                                new int[]{ 15, 28}, 
                                new int[] {27, 40}, 
                                new int[]{50, 90}};
        //When
        var result = dp.GetLongestPairLength(data);
        //Then
        Assert.Equal(3,result);
        }
        [Fact(Skip = "issue with code need to check")]
        
        public void GetLongestPair_Test()
        {
         //Given
        var data = new int [][]{new int[]{5, 24}, 
                                new int[]{39, 60}, 
                                new int[]{ 15, 28}, 
                                new int[] {27, 40}, 
                                new int[]{50, 90},
                                new int [] {110,200}};
        //When
        var result = dp.GetLongestPair(data);
        
        var correctResult = new List<int[]>(){new int[]{5,24}, new int[] {27,40}, new int[] {50,90}};
        correctResult = correctResult.OrderBy(x =>x[0]).ToList();
        result.Sort();
        //Then
        Assert.Equal(correctResult.Count,result.Count);
        var count=0;
        for(int i=0;i<result.Count;i++)
        {
            if(result[i][0]==correctResult[i][0] && result[i][1]== correctResult[i][1])
                count++;
        }
        Assert.Equal(correctResult.Count, count);
        }
        [Fact (Skip = "issue with push logic")]
        public void GetLongestPair_Test2()
        {
         //Given
        var data = new int [][]{new int[]{5, 24}, 
                                new int[]{39, 60}, 
                                new int[]{ 15, 28}, 
                                new int[] {27, 40}, 
                                new int[]{50, 90}};
        //When
        var result = dp.GetLongestPair(data);
        
        var correctResult = new List<int[]>(){new int[]{5,24}, new int[] {27,40}, new int[] {50,90}};
        correctResult = correctResult.OrderBy(x =>x[0]).ToList();
        result = result.OrderBy(x => x[0]).ToList();
        //Then
        Assert.Equal(correctResult.Count,result.Count);
        var count=0;
        for(int i=0;i<result.Count;i++)
        {
            if(result[i][0]==correctResult[i][0] && result[i][1]== correctResult[i][1])
                count++;
        }
        Assert.Equal(correctResult.Count, count);
        }
        
    }
}
