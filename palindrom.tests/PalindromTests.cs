using System;
using Xunit;
using FluentAssertions;

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
}
