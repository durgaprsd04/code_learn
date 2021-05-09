using Xunit;
using System;
using CSharp.Advanced;
namespace CSharp.Test.Advanced
{
    public class SpanTestTest
    {
        [Fact]
        public void TestSpan_Test1()
        {
        //Given
        var x= new SpanTest();
        //When
        var result= x.TestSpan(100,0,5);
        //Then
        Assert.Equal("12345", result);
        }
    }
}