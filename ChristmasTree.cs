using System;
namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int symbolCount = -1;
            int dotsCount = n+1;
            int symbolCount2 = 1;
            int dotsCount2 = n;
            for (int i = 0; i <= n / 2; i++)
            {
                dotsCount--;
                symbolCount += 2;
                string dots = new string('\'', dotsCount);
                string symbol = new string('^', symbolCount);
                Console.WriteLine(dots + symbol + dots);
            }
            for (int i = 1; i <= n/2+1; i++)
            {
                dotsCount2--;
                symbolCount2 += 2;
                string dots = new string('\'', dotsCount2);
                string symbol = new string('^', symbolCount2);
                Console.WriteLine(dots + symbol + dots);
}
            if (n <= 5)
            {
                string lastDots = new string('\'', n - 1);
                Console.WriteLine(lastDots + "| |" + lastDots);
                Console.WriteLine(lastDots + "| |" + lastDots);
                Console.WriteLine(lastDots + "| |" + lastDots);
                Console.WriteLine(lastDots + "| |" + lastDots);
            }
            else
            {
                for (int i = 1; i <= n / 2 + 1; i++)
                {
                    string lastDots = new string('\'', n - 1);
                    Console.WriteLine(lastDots + "| |" + lastDots);
                }
            }
            int dashes = 2 * n + 1;
            string dashSymbols = new string('-', dashes);
            Console.WriteLine(dashSymbols);
                }
            }
}
