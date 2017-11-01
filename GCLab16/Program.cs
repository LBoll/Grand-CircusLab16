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
                int location = LocatePrime(ref repeat, Primes);

                Console.WriteLine($"\nThe number {location} prime is {Primes[location - 1]} \n");

                Console.Write("Would you like to locate another number? (y/n): ");
                repeat = RepeatContinue();
            }
        }

        public static int LocatePrime(ref bool repeat, string[] Primes)
        {
            Console.Write("What number prime would you like the find out? ");
            bool success = false;
            int location = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out location);
                if (!success)
                {
                    Console.Write("\nSorry, that wasn't an integer!");
                    repeat = false;
                }
                if (location > Primes.Length || location < Primes.Length)
                {
                    Console.Write("\nPlease try again! Make sure it is between (1-20): ");
                    success = false;
                }
            }

            return location;
        }

        public static bool RepeatContinue()
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

                    if (answer2 == "y")
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

        /*
        class Class1
        {
             public class Hiker
             {
                 public static int Answer(int x)
                 {
                     int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73 };
            
                     return primes[x - 1];
                 }
             }
             public class HikerTest
             {
                 [Test]
                 public void Case1()
                 {
                     Assert.AreEqual(2, Hiker.Answer(1));
                 }
                 [Test]
                 public void Case2()
                 {
                     Assert.AreEqual(3, Hiker.Answer(2));
                 }
                 [Test]
                 public void Case3()
                 {
                     Assert.AreEqual(5, Hiker.Answer(3));
                 }
                 [Test]
                 public void Case4()
                 {
                     Assert.AreEqual(7, Hiker.Answer(4));
                 }
                 [Test]
                 public void Case5()
                 {
                     Assert.AreEqual(61, Hiker.Answer(18));
                 }
             }
        }
        */
    }
}