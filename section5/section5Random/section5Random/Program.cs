using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section5Random
{
    class Program
    {
        private static int numGuesses = 0;
        static void Main(string[] args)
        {
            
            var rando = new Random();
            var numToGuess = rando.Next(1, 10);
            Console.WriteLine(numToGuess);


            while (numGuesses < 4)
            {
                Console.Write("What number between 1 and 10 am I thinking of: ");
                var input = Console.ReadLine();
                var guess = Convert.ToInt32(input);
                numGuesses++;

                if (numToGuess == guess)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else if (numToGuess != guess && numGuesses < 4)
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                else if(numGuesses == 4)
                {
                    Console.WriteLine("You Lost. The number was {0}.", numToGuess);
                }
                    
            }
            
        }
    }
}
