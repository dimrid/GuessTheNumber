using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    public class GuessTheNumber
    {

        public enum WhoGuess
        {
            Player,
            Computer
        }

        private readonly int maxNumber;
        private readonly int maxTries;
        private readonly WhoGuess whoGuess;
        public GuessTheNumber(int maxNumber = 100, int maxTries = 5, WhoGuess whoGuess = WhoGuess.Player)
        {
            this.maxNumber = maxNumber;
            this.maxTries = maxTries;
            this.whoGuess = whoGuess;
        }


        void Print()
        {
            Console.WriteLine("\tHello! Let's start playing!");
        }
    }
}
