using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());
            ulong bigger = Math.Max(firstNumber, secondNumber);
            ulong smaller = Math.Min(firstNumber, secondNumber);
            string biggerType = "";
            string smallerType = "";
            ulong smallerValue = 0;

            if (bigger >= uint.MinValue && bigger <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (bigger > byte.MinValue && bigger <= ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (bigger > ushort.MinValue && bigger <= uint.MaxValue)
            {
                biggerType = "uint";
            }
            else if (bigger > uint.MaxValue && bigger <= ulong.MaxValue)
            {
                biggerType = "ulong";
            }


            if (smaller >= byte.MinValue && smaller <= byte.MaxValue)
            {
                smallerType = "byte";
                smallerValue = byte.MaxValue;
            }
            else if (smaller > byte.MinValue && smaller <= ushort.MaxValue)
            {
                smallerType = "ushort";
                smallerValue = ushort.MaxValue;
            }
            else if (smaller > ushort.MinValue && smaller <= uint.MaxValue)
            {
                smallerType = "uint";
                smallerValue = uint.MaxValue;
            }
            else if (smaller > uint.MinValue && smaller <= ulong.MaxValue)
            {
                smallerType = "ulong";
                smallerValue = ulong.MaxValue;
            }

            Console.WriteLine("bigger type: {0}", biggerType);
            Console.WriteLine("smaller type: {0}", smallerType);
            int result = (int)Math.Round((double)bigger / smallerValue);
            Console.WriteLine("{0} can overflow {1} {2} times", bigger, smallerType, result);
        }
    }
}
