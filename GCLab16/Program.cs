using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Welcome to the Prime Number locator!");
            string[] Primes = { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71" };

            while (repeat)
            {

                Console.Write("What number prime would you like the find out? ");
                bool success = false;
                int location = 0;
                while (!success)
                {
                    success = int.TryParse(Console.ReadLine(), out location);
                    if (!success)
                    {
                        Console.Write("Sorry, that wasn't an integer. Please try again: ");
                        repeat = false;
                    }
                }
                Console.WriteLine($"The number {location} prime is {Primes[location - 1]} ");

                Console.Write("Would you like to locate another number? (y/n): ");
                repeat = GetYesorNo();
            }
        }
        private static bool GetYesorNo()
        {
            bool repeat = true;
            bool success = true;
            while (repeat)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    repeat = false;
                    success = true;
                }
                else if (answer == "n")

                {
                    Console.Write("Are you really, really sure you are done locating prime numbers...? (y/n) ");
                    string answer2 = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        repeat = false;
                        success = true;
                    }
                    else if (answer2 == "n")
                    {
                        Console.WriteLine("Fine, goodbye! ");
                        repeat = false;
                        success = false;
                    }
                    else
                    {
                        Console.Write("I'm sure we have already been over this. Try again: ");
                    }
                }
                else
                {
                    Console.Write("Please just stick to y/n, I'm not that smart. Try again: ");
                }
            }
            return success;
        }
    }
}