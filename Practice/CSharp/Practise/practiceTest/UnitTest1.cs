using System;
using Xunit;
using Practise;

namespace practiceTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var str1 = "abcdefgh";
            var str2 = "a";
            var str3  = "za";
            var result = str1.MyReplace( str2, str3);
            Assert.Equal("zabcdefgh", result);
        }
        [Fact]
        public void Test2()
        {
            var str1 = "abcdefgh";
            var str2 = "abcd";
            var str3  = "za";
            var result = str1.MyReplace( str2, str3);
            Assert.Equal("zaefgh", result);
        }
        [Fact]
        public void Test3()
        {
            var str1 = "abcdefgh";
            var str2 = "abcdf";
            var str3  = "za";
            var result = str1.MyReplace( str2, str3);
            Assert.Equal("abcdefgh", result);
        }
        [Fact]
        public void Test4()
        {
            var str1 = "abcdeabcdffgh";
            var str2 = "abcdf";
            var str3  = "za";
            var result = str1.MyReplace( str2, str3);
            Assert.Equal("abcdezafgh", result);
        }
    }
}
