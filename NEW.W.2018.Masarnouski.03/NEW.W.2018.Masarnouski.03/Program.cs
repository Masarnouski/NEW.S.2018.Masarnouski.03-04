using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NEW.W._2018.Masarnouski._03
{
    class Program
    {
        static void Main(string[] args)
        {

            //double i = -255.255;

            //Int64 temp = Convert.ToInt64(i);
            //Console.WriteLine(temp);

            //string result = Convert.ToString(temp, 2);
            //Console.WriteLine(result);

            //var bites = new BitArray(BitConverter.GetBytes(-255.255));
            //foreach (var item in bites)
            //{
            //    Console.Write(item + " , ");
            //}
            //Console.ReadLine();

            double x = -255.255;
            Console.Write(x.ToIEEE754Format());
            Console.ReadLine();
            //TimeSpan time = new TimeSpan();

            //Console.WriteLine(NodCount.Evklid(out time, 0, 8, 4));
            //Console.WriteLine(time);
            //Console.Write(time.TotalMilliseconds);
            //Console.ReadLine();
            //Console.Write(time.TotalMilliseconds>0);
            //Console.ReadLine();
            //Console.WriteLine(NodCount.Stein_NOD(0,750,780));
            //Console.ReadLine();


        }
    }
}
