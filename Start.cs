using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Start
    {
        public static void Main()
        {
            GetGreetings(); // The first step is greetings

            string userInput = "";

            while (true)
            {
                switch (GetUserCorrectAnswer(userInput)) // The second step is getting an answer from the user
                {
                    case 1:
                        PlayerGuesses();
                        break;
                    case 2:
                        ComputerGuesses();
                        break;
                }
            }

        }
        private static void GetGreetings()
        {
            Console.WriteLine("Hello! Let's start playing!");

            Console.WriteLine("You need to guess the number from 0 to 100.");

            Console.WriteLine("Who is playing?\nIf human vs. human, enter: 1.\nIf human vs. computer enter: 2.");
        }
        static int GetUserCorrectAnswer(string input)
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out int result) && (result == 1 || result == 2))
            {
                return result;
            }
            else
            {
                Console.WriteLine("You're wrong! Try again!");
            }
            return result;
        }

        static void ComputerGuesses()
        {
            Console.WriteLine("I guessed a number. Try to guess");

            Random rnd = new Random();

            int guessed = rnd.Next(0, 100);

            int tries = 5;

            while (tries < 5 || guessed == GetUserCorrectAnswer(""))
            {
                Console.WriteLine($"MY CONGRATULATIONS!!!! YOU WIN!! My number is {guessed}");
            }

        }
        static void PlayerGuesses()
        {
            int index = 0;

            string player_2 = Console.ReadLine();

            int playerParse_2 = int.Parse(player_2);


            for (int i = 0; i < 5; i++)
            {
                if (playerParse_2 == index)
                {
                    Console.WriteLine($"MY CONGRATULATIONS!!!! YOU WIN!! The Guessed number is {index}");
                    break;
                }
                if (playerParse_2 > index)
                {
                    Console.WriteLine($"Your number is more. Try again");

                    int[] arrayMore = new int[playerParse_2];

                }
                if (playerParse_2 < index)
                {
                    Console.WriteLine($"Your number is less. Try again");
                }
                else if (true)
                {
                    Console.WriteLine("NO! Please. Try again");
                }
            }
            Console.WriteLine("Human");
            Console.WriteLine("Please, PLAYER 1 enter the number:");



            string player_1 = Console.ReadLine();

            int playerParse_1 = int.Parse(player_1);

            Console.WriteLine("I've got your number.");

            Console.WriteLine("Please, PLAYER 2 enter the number:");
        }

    }
}

