using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|        Programming Puzzle: The Game of Threes            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|        1. Start with a positive integer.                 |");
            Console.WriteLine("|        2. If possible, divide by 3.                      |");
            Console.WriteLine("|        3. If not, add or subtract 1 to make it possible. |");
            Console.WriteLine("|        4. Continue until the number is equal to 1.       |");
            Console.WriteLine("|__________________________________________________________|\n");

            Console.WriteLine("Enter a number: ");
            int playerNumber = Convert.ToInt32(Console.ReadLine());
            int originalNumber = playerNumber;
            int steps = 0;

            while (playerNumber != 1)
            {
                if (playerNumber % 3 == 0)
                {
                    playerNumber /= 3;
                    Console.WriteLine(playerNumber + " (divided by 3)");
                    steps += 1;
                }
                else if (playerNumber % 3 == 1)
                {
                    playerNumber -= 1;
                    Console.WriteLine(playerNumber + " (subtracted 1)");
                    steps += 1;
                }
                else if (playerNumber % 3 == 2)
                {
                    playerNumber += 1;
                    Console.WriteLine(playerNumber + " (added 1)");
                    steps += 1;
                }
            }
            Console.WriteLine("\n____________________________________________________________");
            Console.WriteLine($"\n You won! You started with {originalNumber}, it took {steps} steps to hit 1.");
            Console.WriteLine("____________________________________________________________");
            Console.ReadLine();
        }
    }
}
