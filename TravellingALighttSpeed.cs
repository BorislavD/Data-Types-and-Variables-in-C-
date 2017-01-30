using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingALighttSpeed
{
    using System.Globalization;

    class TravellingALighttSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal distance = lightYears * 9450000000000m;
            int speed = 300000;
            decimal time = distance / speed;
            
            TimeSpan difference = TimeSpan.FromSeconds((double)time);
            string formatted = string.Format(
                  CultureInfo.CurrentCulture,
                  "{0:f0} weeks\n{1:f0} days\n{2:f0} hours\n{3:f0} minutes\n{4:f0} seconds\n",
                 difference.Days / 7,
                  difference.Days % 7,
                  difference.Hours,
                  difference.Minutes,
                  difference.Seconds);
            Console.WriteLine(formatted);
        }
    }
}
