using System;
using Xunit;
using FluentAssertions;
using palindrom;

namespace palindrom.tests
{
    public class PalindromTests
    {
        [Theory(DisplayName = "ระบบสามารถตรวจสอบได้ว่าข้อมูลที่ใส่เข้ามาเป็น palindrom ได้ถูกต้อง")]
        [InlineData("aa", true)]
        [InlineData("aabaa", true)]
        [InlineData("112211", true)]
        [InlineData("aa112aa", false)]
        [InlineData("aa!!aa", true)]
      
        public void SystemMustBeDetectPalindromCorrectly(string input, bool expectedResult)
        {
            var sut = new PalindromChecker();
            var actual = sut.IsPalindrom(input);
            actual.Should().Be(expectedResult);
        }
    }

    public class PalindromMultipleTests
    {
        [Theory(DisplayName = "ระบบสามารถตรวจสอบได้ว่าข้อมูลที่ใส่เข้ามา-ผลคูณ-เป็น palindrom ได้ถูกต้อง")]
        [InlineData(11,1,true)]
        [InlineData(22,11, true)]
        [InlineData(1,1, true)]
        [InlineData(5,5, false)]
        [InlineData(1000,1000, false)]
        //[InlineData("a","a", false)]
        public void SystemMustBeDetectPalindromCorrectly(int input,int input2, bool expectedResult)
        {
            var sut = new PalindromChecker();
            var actual = sut.IsMultiplePalindrom(input,input2);
            actual.Should().Be(expectedResult);
        }
    }
}

