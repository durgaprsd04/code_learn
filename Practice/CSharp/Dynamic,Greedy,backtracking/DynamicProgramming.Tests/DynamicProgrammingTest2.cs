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
        [Fact]
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
        [Fact(Skip="invalid testcase")]
        public void GetLongestPair_Test3()
        {
         //Given
        var data = new int [][]{new int[]{11, 20}, 
                                new int[]{10, 40}, 
                                new int[]{ 45,60}, 
                                new int[] {39, 40}};
        //When
        var result = dp.GetLongestPair(data);
        
        var correctResult = new List<int[]>(){new int[]{11,20}, new int[] {39,40}, new int[] {45,60}};
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
        [Fact]
        public void TestName()
        {
        //Given
        var dp1 = new int[3][];
        for(int i=0;i<3;i++)
        {
                dp1[i] = new int[3]{3*i+1,3*i+2, 3*i+3};
        }
        //When
        var res = dp.MaximumAverageValue(dp1,3);
        //Then
         Assert.Equal(5.8,res);
        }
        [Fact]
        public void MaximumTrianglePathTest_Test1()
        {
        //Given
        var triangle = new int [4] [];
        triangle[0]=new int [] {3};
        triangle[1] =new int []  {7,4};
        triangle[2] = new int[]{2,4,6};
        triangle[3] =new int[]{8,5,9,3};
        
        //When
        var res = dp.MinimumPathSumTriangle(triangle);
        //Then
        Assert.Equal(23, res);
        }
        [Fact]
        public void MaximumTrianglePathTest_Test2()
        {
        //Given
        var triangle = new int [4] [];
        triangle[0]=new int [] {8};
        triangle[1] =new int []  {-4,4};
        triangle[2] = new int[]{2,2,6};
        triangle[3] =new int[]{1,1,1,1};
        
        //When
        var res = dp.MinimumPathSumTriangle(triangle);
        //Then
        Assert.Equal(19, res);
        }
        [Fact]
        public void MaximumSumofArrayWithSpecificDifference_Test1()
        {
        //Given
         var arr =new int [] {3, 5, 10, 15, 17, 12, 19};
        //When
         var res = dp.MaximumSumofArrayWithSpecificDifference(arr, 4);
        //Then
        Assert.Equal(71,res);
        }
        [Fact]
        public void SizeOfMaxMatrix_Test1()
        {
        //Given
        int [][]arr = new int[6][];
            arr[0] =new int[]{0,1,1,0,1};
            arr[1] =new int[]{1,1,0,1,0};
            arr[2] =new int[]{0,1,1,1,0};
            arr[3] =new int[]{1,1,1,1,0};
            arr[4] =new int[]{1,1,1,1,1};
            arr[5] =new int[]{0,0,0,0,0};
        //When
        var result = dp.SizeOfMaxMatrix(arr);
        //Then
        Assert.Equal(3, result);
        }
        [Fact]
        public void MaxJumpPositions_Test1()
        {
        //Given
        var arr = new int[]{2, 3, 1, 4, 6, 5};
        //When
        var res =dp.MaxJumpPositions(arr);
        //Then
        Assert.Equal(new int[]{2,5,3,9,8,10}, res);
        }
    }
}
