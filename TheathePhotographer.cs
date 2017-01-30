using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheathePhotographer
{
    using System.Globalization;
    using System.Numerics;

    class TheathePhotographer
    {
        static void Main(string[] args)
        {
            int picturesTotal = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int picturesUsefull = (int)Math.Ceiling(picturesTotal * filterFactor / 100.00);
            //long timeForUploading = (long) (picturesUsefull * uploadTime);
            //long timeForFiltering = (long) (picturesTotal * filterTime);
            //long timeTotal = (long) (timeForFiltering + timeForUploading);

            BigInteger timeForUploading = BigInteger.Multiply(picturesUsefull, uploadTime);
            BigInteger timeForFiltering = BigInteger.Multiply(picturesTotal, filterTime);
            BigInteger timeTotal = BigInteger.Add(timeForFiltering, timeForUploading);

            TimeSpan time = TimeSpan.FromSeconds((double)timeTotal);
   //         string result = time.ToString("d\\:hh\\:mm\\:ss");
            string resultOtherWay = string.Format(
                CultureInfo.CurrentCulture,
                "{0}:{1:0#.##}:{2:0#.##}:{3:0#.##}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
          //  Console.WriteLine(result);
            Console.WriteLine(resultOtherWay);

        }
    }
}
