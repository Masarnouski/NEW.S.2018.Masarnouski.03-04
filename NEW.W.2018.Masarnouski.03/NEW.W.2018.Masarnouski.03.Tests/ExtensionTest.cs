using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;

namespace NEW.W._2018.Masarnouski._03.Tests
{
    [TestFixture]
    public class ExtensionTest
    {
    /// <summary>
    ///  Tests the correct convertation double number to string binary IEEE754 format
    /// </summary>
    /// <param name="number">Number to convers</param>
    /// <returns> string binary representation of number </returns>
        [Test]
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
        public string ToIEEE754Format_CheckArguments(double number)
        {
           return number.ToIEEE754Format();
        }
        /// <summary>
        /// Tests that execution time is grater then 0
        /// </summary>
        /// <param name="number">number to convert</param>
        [Test]
        [TestCase(-255.255)]
        [TestCase(255.255)]
        [TestCase(4294967295.0)]
        [TestCase(double.MinValue)]
        [TestCase(double.MaxValue)]
        [TestCase(double.Epsilon)]
        [TestCase(double.NaN)]
        [TestCase(double.NegativeInfinity)]
        [TestCase(double.PositiveInfinity)]
        public void ToIEEE754Format_Time_Greater_then_0(double number)
        {
            TimeSpan time = new TimeSpan();
            Extension.GetTime(number,out time);
            Assert.IsTrue(time.TotalMilliseconds > 0, $"Time is {time.TotalMilliseconds}");
        
        }
    }
}
