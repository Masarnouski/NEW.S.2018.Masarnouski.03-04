using System;
using NUnit.Framework;
using NEW.W._2018.Masarnouski._03;

namespace NEW.W._2018.Masarnouski._03.Tests
{
    [TestFixture]
    public class NodCountTest
    {
        /// <summary>
        /// Tests the correct greatest common divisor of Evclidean's method with different arguments
        /// </summary>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The first number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        /// <returns> The greatest common divisor </returns>
        [Test]
        [TestCase(4 ,8 ,16, ExpectedResult = 4)]
        [TestCase(49, 56, 70, ExpectedResult = 7)]
        [TestCase(64, 56, 72, ExpectedResult = 8)]
        [TestCase(-4, -8, 16, ExpectedResult = 4)]
        [TestCase(0, 8, 4, ExpectedResult = 4)]
        public int Evclid_CheckArguments(int number1, int number2, params int[] numbers)
        {
           return NodCount.Evklid(number1, number2, numbers);
        }
        /// <summary>
        /// Tests the correct greatest common divisor of Stein's method with different arguments
        /// </summary>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The first number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        /// <returns> The greatest common divisor </returns>
        [Test]
        [TestCase(4, 8, 16, ExpectedResult = 4)]
        [TestCase(49, 56, 70, ExpectedResult = 7)]
        [TestCase(64, 56, 72, ExpectedResult = 8)]
        [TestCase(-4, -8, 16, ExpectedResult = 4)]
        [TestCase(0, 8, 4, ExpectedResult = 4)]
        public int Stein_CheckArguments(int number1, int number2, params int[] numbers)
        {
            return NodCount.Evklid(number1, number2, numbers);
        }
        /// <summary>
        /// Tests that execution time by Evclidean's mehtod is greater then zero
        /// </summary>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The first number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        [Test]
        [TestCase(4, 8, 16)]
        [TestCase(49, 56, 70)]
        [TestCase(64, 56, 72)]
        [TestCase(-4, -8, 16)]
        public void Evklid_Time_Greater_Then_0(int number1, int number2, params int[] numbers)
        {
            TimeSpan time = new TimeSpan();
            int result = NodCount.Evklid(out time,number1, number2, numbers);
            Assert.IsTrue(time.TotalMilliseconds > 0, $"Time is {time.TotalMilliseconds}");
        }
        /// <summary>
        /// Tests that execution time by Stein's method is greater then zero
        /// </summary>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The first number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        [Test]
        [TestCase(4, 8, 16)]
        [TestCase(49, 56, 70)]
        [TestCase(64, 56, 72)]
        [TestCase(-4, -8, 16)]
        public void Stein_Time_Greater_Then_0(int number1, int number2, params int[] numbers)
        {
            TimeSpan time = new TimeSpan();
            int result = NodCount.Stein(out time, number1, number2, numbers);
            Assert.IsTrue(time.TotalMilliseconds > 0, $"Time is {time.TotalMilliseconds}");
        }
    }
}
