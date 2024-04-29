using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number!");
        // int magicNumber = int.Parse(Console.ReadLine());
        // Console.WriteLine("What is your guess?");

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);
        Console.Write("I have selected a number between 1-100.  What is your guess?");

        int guess = -1;
        while (guess != magicNumber)
        {
            // this will update the value of the guess otherwise -1 will always be the number
            guess = int.Parse(Console.ReadLine()); 

            if (magicNumber  > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!"); 
            }
        }
      }
    }
