using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal moneyPerKM = decimal.Parse(Console.ReadLine());

            long runnersMax = days * capacity;
            long participants = runnersMax - runners;
            if (participants >= 0)
            {
                participants = runners;
            }
            else
            {
                participants = runnersMax;
            }

            ulong totalMeters = (ulong)(participants * laps * length);
            decimal totalKilometers = totalMeters / 1000m;

            decimal rezult = totalKilometers * moneyPerKM;
            Console.WriteLine("Money raised: {0:f2}", rezult);
        }
    }
}
