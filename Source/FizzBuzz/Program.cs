using System;
using System.Globalization;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start....");

            FizzBuzz(1);
           
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void FizzBuzz(int i) //0
        {
            if (i <= 100)
            {
                GameNumber gameNumber;

                if (i % 15 == 0)
                {
                    gameNumber = new GameNumber("FizzBuzz");
                }
                else if (i%3 == 0)
                {
                    gameNumber = new GameNumber("Fizz");
                }
                else if (i%5 == 0)
                {
                    gameNumber = new GameNumber("Buzz");
                }
                else
                {
                    gameNumber = new GameNumber(i.ToString(CultureInfo.InvariantCulture));
                }
                Console.WriteLine(gameNumber.Value);

                FizzBuzz(i + 1);
            }
        }
    }
}
