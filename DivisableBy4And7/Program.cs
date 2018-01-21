using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DivisableBy4And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 100; i <= 120; i++)
            {
                bool divisibleBy4 = i % 4 == 0;
                bool divisibleBy7 = i % 7 == 0;

                if (divisibleBy7 && divisibleBy4)
                {
                    int[] array1 = { i };
                    Console.WriteLine(array1.Sum()); 
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken: " + stopWatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'milliseconds'"));
            //TimeSpan ts = stopWatch.Elapsed;

            //string elapsedTime = String.Format("{0:00}: {1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);

            //Console.WriteLine("Runtime " + elapsedTime);

            Console.ReadLine();
        }
    }
}
