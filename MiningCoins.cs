using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins
{
    class MiningCoins
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = String.Empty;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                int threeDigitNumber = int.Parse(Console.ReadLine());
                
                while (threeDigitNumber > 0)
                {
                    int lastDigit = threeDigitNumber % 10;
                    list1.Insert(0, lastDigit);
                    threeDigitNumber = threeDigitNumber / 10;
                }

                list2.Add(list1[0]);
                list2.Add(list1[2]);

                int num = 10 * list2[0] + list2[1];

                if (i % 2 != 0)
                {
                    num = num + list1[1];
                }
                else
                {
                    num = num - list1[1];
                }

                if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                {
                    result = result + (char)num;
                }

                sum += list1[0] + list1[1] + list1[2];
            }

            float valueResult = (float)sum / n;
            Console.WriteLine("Message: {0}", result);
            Console.WriteLine("Value: {0:F7}", valueResult);
        }
    }
}
