using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.W._2018.Masarnouski._03
{
    /// <summary>
    /// Responsible for calculating the greatest common divisor
    /// </summary>
    public class NodCount
    {
        /// <summary>
        /// Calculates greatest common divisor of 3 and more numbers by Evklidean's way
        /// </summary>
        /// <param name="number1"> The first number to calculate</param>
        /// <param name="number2"> The second number to calculate </param>
        /// <param name="numbers"> Array of numbers to calculate </param>
        /// <returns> The greatest common divisor </returns>
        public static int Evklid(int number1, int number2, params int[] numbers)
        {
            int temp = Evklid(number1, number2);
            int i = 0;
            while (i < numbers.Length)
            {
                temp = Evklid(temp, numbers[i]);
                i++;
            }

            return temp;
        }

        /// <summary>
        /// Calculates greatest common divisor of 3 and more numbers by Stein's way
        /// </summary>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The second number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        /// <returns>The greatest common divisor</returns>
        public static int Stein(int number1, int number2, params int[] numbers)
        {
            int temp = 0;
            temp = Stein(number1, number2);
            for (int i = 2; i < numbers.Length; i++)
            {
                temp = Stein(temp, numbers[i]);
            }

            return temp;
        }

        /// <summary>
        /// Calculates greatest common divisor of 3 and more numbers by Evklidean's way
        /// </summary>
        /// <param name="time"> The out parameter which stores a execution time </param>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The second number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        /// <returns>The greatest common divisor</returns>
        public static int Evklid(out TimeSpan time, int number1, int number2, params int[] numbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = Evklid(number1, number2, numbers);
            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return result;
        }

        /// <summary>
        /// Calculates greatest common divisor of 3 and more numbers by Stein's way
        /// </summary>
        /// <param name="time"> The out parameter which stores a execution time </param>
        /// <param name="number1">The first number to calculate</param>
        /// <param name="number2">The second number to calculate</param>
        /// <param name="numbers">Array of numbers to calculate</param>
        /// <returns>The greatest common divisor</returns>
        public static int Stein(out TimeSpan time, int number1, int number2, params int[] numbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = Stein(number1, number2, numbers);
            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return result;
        }
        #region Private Methods
        private static int Evklid(int number1, int number2)
        {
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if (number1 == 0)
                return number2;

            if (number2 == 0)
                return number1;

            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else
                {
                    number2 = number2 - number1;
                }
            }

            return number1;
        }

        private static int Stein(int number1, int number2)
        {
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if (number1 == number2)
                return number1;

            if (number1 == 0)
                return number2;

            if (number2 == 0)
                return number1;

            if ((~number1 & 1) != 0)
            {
                if ((number2 & 1) != 0)
                    return Stein(number1 >> 1, number2);
                else
                    return Stein(number1 >> 1, number2 >> 1) << 1;
            }

            if ((~number2 & 1) != 0)
                return Stein(number1, number2 >> 1);
            if (number1 > number2)
                return Stein((number1 - number2) >> 1, number2);
            return Stein((number2 - number1) >> 1, number1);
        }
    }
}
    #endregion