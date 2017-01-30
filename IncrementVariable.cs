using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte s = 0;
            int counteOverflow = 0;
            for (int i = 0; i < n; i++)
            {
                s++;
                if (s == 0)
                {
                    counteOverflow++;
                }
            }

            Console.WriteLine(s);
            if (counteOverflow > 0)
            {
                Console.WriteLine("Overflowed {0} times", counteOverflow);
            }
        }
    }
}
