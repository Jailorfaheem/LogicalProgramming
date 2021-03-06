using System;

namespace BasicLogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Program Number : ");
            Console.WriteLine();
            Console.WriteLine("1 = Fibonacci Number Series \n2 = Perfect Number \n3 = Prime Number \n4 = Reverse Number \n5 = StopWatch");
            Console.Write("\nProgram number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.fibonacci();
                    break;
                case 2:
                    PerfectNumber perfectnum = new PerfectNumber();
                    perfectnum.perfectNumber();
                    break;
                case 3:
                    PrimeNumber primenum = new PrimeNumber();
                    primenum.primeNumber();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.reverseNumber();
                    break;
                case 5:
                    StopWatch stopwatch = new StopWatch();
                    stopwatch.stopWatch();
                    break;
            }
        }
    }
}