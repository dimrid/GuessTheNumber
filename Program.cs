using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Let's start playing!");

            Console.WriteLine("You need to guess the number from 0 to 100.");

            Console.WriteLine("Who is playing?\nIf human vs. human, enter: 1.\nIf human vs. computer enter: 2.");
            
            int choiseUser;

            while (true)
            {
                string choice = Console.ReadLine();
                
                choiseUser = int.Parse(choice);

                switch (choiseUser)
                {
                    case 1:
                        PlayerGuesses();
                        break;
                    case 2:
                        ComputerGuesess();
                        break;
                    default:
                    Console.WriteLine("You're wrong!");
                        break;
                }
            }
            switch (choiseUser)
            {
                case 1:
                    Console.WriteLine("Please, PLAYER 1 enter the number:");

                    string player_1 = Console.ReadLine();

                    int playerParse_1 = int.Parse(player_1);

                    Console.WriteLine("I've got your number.");

                    Console.WriteLine("Please, PLAYER 2 enter the number:");
                    break;
                case 2:
                    index = GetNumber();
                    break;
                default:
                    Console.WriteLine("Do not do it!");
                    break;
            }




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

        }

        private static void ComputerGuesess()
        {
            throw new NotImplementedException();
        }

        private static void PlayerGuesses()
        {
            throw new NotImplementedException();
        }

        static int GetNumber()
        {
            Random random = new Random();


            int randNum = random.Next(0, 100);

            return randNum;
        }
        int GetArrays(int player)
        {
            int[] numbers = new int[101];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[0 + i] = i;
            }

            int index = Array.BinarySearch(numbers, player);

            return index;
        }

    }
}

