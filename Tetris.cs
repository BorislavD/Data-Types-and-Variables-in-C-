using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Tetris
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (!input.Equals("exit"))
            {
                if (input.Equals("left"))
                {
                    PrintLeft(n);
                }
                else if (input.Equals("right"))
                {
                    PrintRight(n);
                }
                else if (input.Equals("down"))
                {
                    PrintDown(n);
                }
                else
                {
                    PrintUp(n);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintLeft(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n));
                Console.WriteLine(new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n));
                Console.WriteLine(new string('*', n));
            }
        }

        private static void PrintRight(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', n));
                Console.WriteLine(new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', n));
                Console.WriteLine(new string('.', n));
            }
        }

        private static void PrintDown(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 3 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.WriteLine(new string('.', n));
            }
        }

        private static void PrintUp(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.WriteLine(new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 3 * n));
            }
        }
    }
}
