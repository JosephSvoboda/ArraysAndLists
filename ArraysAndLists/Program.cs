using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 - DONE!
            int[] myArray = new int[10];

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds" - DONE!
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List - DONE!
             * or the odds List
             */
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers - DONE!
             *
             * Try to be creative in your display
             */
            foreach (int i in evens)
            {
                if (i == evens.Count)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            foreach (int i in odds)
            {
                if (i == odds.Count)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}