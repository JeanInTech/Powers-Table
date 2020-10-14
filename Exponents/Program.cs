using System;
using System.Reflection.Metadata.Ecma335;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your sqaures and cubes!");

            bool userContinue = true;

            while (userContinue)
            {
                Console.WriteLine(Environment.NewLine + "Enter an integer: ");

                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Number \t Squared \t Cubed ");
                    Console.WriteLine("====== \t ======= \t ======");

                    for (int i = 1; i <= userInput; i++)
                    {
                        Console.WriteLine($"{i} \t {Squared(i)} \t\t {Cubed(i)}");
                    }

                    while (userContinue)
                    {
                        Console.WriteLine(Environment.NewLine + "Continue? (y/n)");
                        string proceed = Console.ReadLine().ToLower().Trim();

                        if (proceed == "n")
                        {
                            userContinue = false;
                        }
                        else if (proceed != "n" && proceed != "y")
                        {
                            Console.WriteLine("Invalid input");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please input a valid number.");
                    continue;
                }
            }
            Console.WriteLine(Environment.NewLine + "Goodbye!");
        }



        public static int Squared(int num)
        {
            int input = num;
            return input * input;
        }

        public static int Cubed(int num)
        {
            int input = num;
            return input * input * input;
        }
    }
}
