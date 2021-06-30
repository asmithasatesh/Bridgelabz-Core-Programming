using System;
using System.Diagnostics;
using System.Threading;
namespace CoreProgramming
{
    class Simulate_stopwatch
    {
        public static void ReadInput()
        {
            //Get input from user
            int timeLapse;
            Console.WriteLine(" Enter the time Stopwatch should end (IN SECONDS)");
            timeLapse = Convert.ToInt32(Console.ReadLine());
            SimulateStopwatch(timeLapse);
        }


        private static void SimulateStopwatch(int timeLapse)
        {
            //Instantiate stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            //Taking longer to execute
           /* for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(timeLapse);
            }
           */

            // TimeSpan  in hours, minutes, seconds(alternative)
            TimeSpan ts = new TimeSpan(0, 0, timeLapse);
            Thread.Sleep(ts);
            stopwatch.Stop();

            // Time elapsed in hour:min:second format
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}