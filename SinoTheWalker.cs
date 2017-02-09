using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    using System.Data.SqlTypes;
    using System.Globalization;
    using System.Numerics;

    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            TimeSpan inputTime = TimeSpan.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timeInSecondsForEachStep = int.Parse(Console.ReadLine()) % 86400;
            long secondsToAdd = (long)(steps * timeInSecondsForEachStep);
            TimeSpan secondsToAddTransformed = TimeSpan.FromSeconds(secondsToAdd);
            TimeSpan endTime = inputTime + secondsToAddTransformed;
            string result = endTime.ToString("hh\\:mm\\:ss");
            Console.WriteLine("Time Arrival: {0}", result);
        }
    }
}
