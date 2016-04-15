using System;

namespace Lanzon.FitnessApp
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(entry);

                    runningTotal += minutes;

                    Console.WriteLine("You've entered " + runningTotal +  " minutes");
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
