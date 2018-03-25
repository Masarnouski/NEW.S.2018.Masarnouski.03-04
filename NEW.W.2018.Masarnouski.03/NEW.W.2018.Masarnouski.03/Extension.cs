using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.W._2018.Masarnouski._03
{
    /// <summary>
    /// Respresent extension methods
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Converts number to a binary IEEE764 format
        /// </summary>
        /// <param name="number"> Number to convert </param>
        /// <returns> String binary represent of number </returns>
        public static string ToIEEE754Format(this double number)
        {
            var bitArray = new BitArray(BitConverter.GetBytes(number));

            var res = new StringBuilder(64);

            for (int i = bitArray.Length-1; i >= 0; i--)
            {
                if (bitArray[i] == false)
                    res.Append('0');
                else
                    res.Append('1');
            }
            return res.ToString();
        }
        public static string GetTime(double number, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string result = number.ToIEEE754Format();
            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return result;
        }

    }
}
