using System;
namespace SnakeAndLadder_Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game.");
            Console.WriteLine();
            Console.WriteLine("Player mode:single: Starting position at 0");
            Console.WriteLine("*Start Game*");

            //Variables
            int position = 0;

            Random die = new Random();
            int dice = die.Next(1, 7);
            Console.WriteLine("The number on this die roll is: " + dice);
            Console.ReadLine();
        }
    }
}