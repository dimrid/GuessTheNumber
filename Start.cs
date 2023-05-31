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
        static string userInput = "";

        public static void Main()
        {
            
            GetGreetings(); // The first step is greetings

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
                if (userInput == "500")
                    break;
            }
        }

        private static void GetGreetings()
        {
            Console.WriteLine("Hello! Let's start playing!");

            Console.WriteLine("You need to guess the number from 0 to 100. And you have 5 tries");

            Console.WriteLine("Who is playing?\nIf human vs. human, enter: 1.\nIf human vs. computer enter: 2.");
        }

        static int GetUserCorrectAnswer(string input)
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out int result) && (result == 1 || result == 2))
            {
                return result;
            }
            else if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("You're wrong! Try again!");
            }
            return result;
        }

        static void PlayerGuesses()
        {
            Console.WriteLine("I guessed a number. Try to guess");

            int userNumber = -1;

            int tries = 0;

            int min = 0;

            int max = 100;

            int maxTries = 5;

            Random rnd = new Random();

            int guessed = rnd.Next(min, max);

            while (tries < maxTries)
            {
                userNumber = GetUserCorrectAnswer(userInput);

                if (guessed == userNumber)
                {
                    Console.WriteLine($"MY CONGRATULATIONS!!!! YOU WIN!! My number is {guessed}");
                    break;
                }
                else if (guessed < userNumber)
                {
                    Console.WriteLine("My number is lower");
                }
                else
                {
                    Console.WriteLine("My number is above");
                }
                tries++;
            }

            if (tries == 5)
            {
                Console.WriteLine($"You lost! My number is {guessed}");
            }
        }

        static void ComputerGuesses()
        {
            int guessedNumber = -1;

            int lastGuess = -1;

            int min = 0;

            int max = 100;

            int trise = 0;

            while (guessedNumber == -1)
            {
                int playerParse = GetUserCorrectAnswer(userInput);

                if (playerParse >= 0 && playerParse <= 100)
                {
                    guessedNumber = playerParse;
                }

            }

            while (lastGuess != guessedNumber && trise < 5)
            {
                lastGuess = (min + max) / 2;
                
                Console.WriteLine($"Is it your number {lastGuess}?");
                
                Console.WriteLine("If Yes. Enter: 'y'\nIf number is greater. Enter: 'g'\nIf number is less: 'l'");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "y":
                        Console.WriteLine("I guessed your number!Man!");
                        break;
                    case "g":
                        min = lastGuess;
                        break;
                    case "l":
                        max = lastGuess;
                        break;
                    default:
                        Console.WriteLine("Don't cheat! Man!");
                        break;
                }
                trise++;
                if(trise == 5)
                {
                    Console.WriteLine("I Lost");
                }
            }
        }

    }
}

