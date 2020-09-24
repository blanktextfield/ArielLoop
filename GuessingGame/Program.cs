using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            int randomNumber = rmd.Next(1, 11);
            Console.WriteLine("What's my number?");
            int userGuess = Int32.Parse(Console.ReadLine());
            bool correctGuess = false;

            while (!correctGuess)
            { 
                if (randomNumber > userGuess)
                {
                    Console.WriteLine("my number is bigger.");
                    Console.WriteLine("What's my number?");
                    userGuess = Int32.Parse(Console.ReadLine());
                
                
                } else
                { 
                  Console.WriteLine("My number is smaller.");
                      Console.WriteLine("What's my number?");
                    userGuess = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}
