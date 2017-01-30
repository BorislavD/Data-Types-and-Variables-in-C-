using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                result += input + str;
            }

            result = result.Substring(0, result.Length - str.Length);
            Console.WriteLine(result);
        }
    }
}
