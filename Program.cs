using System;
namespace SnakeAndLadder_Day_4
{
    class Program
    {
        //Constants 
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;
        private static int opt = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game.");
            Console.WriteLine();
            Console.WriteLine("Player mode:single: Starting position at 0");
            Console.WriteLine("*Start Game*");
            //Variables
            int position = 0;
            Random die = new Random();     //creatting random object from random class
            Random options = new Random();

            while (position < FINAL)
            {
                int dice = die.Next(1, 7);       //simulating the die throw 
                Console.WriteLine("The number on this die roll is: " + dice);
                if (opt == LADDER)
                {
                    position = position + dice;
                    if (position > 100)
                    {
                        Console.WriteLine("Try Again, throw exceeded 100!");
                        position = position - dice;
                    }
                    else
                    {
                        Console.WriteLine("Ladder! new postion-- " + position);
                    }

                }
                else
                {
	    
                    {
                        position = 0;
                    }
                }

            }




        }
    }
}