using System;

namespace ArielLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();

            int myRandomNumber = rmd.Next(1, 11);
            //Console.WriteLine($"Your random number is {myRandomNumber}");
            Console.WriteLine("Whay's my number from 1 to 10: ");
            int userGuess = Int32.Parse(Console.ReadLine());

            if(myRandomNumber == userGuess)
            {
                Console.WriteLine("Congratiulations! You've played me!");
            }else
            {
                Console.WriteLine($"You stupid! My random number is {myRandomNumber}");
            }

        }


    }
}
