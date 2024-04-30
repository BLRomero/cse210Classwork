using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        
        Console.Write("Please enter your name.");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        double square = Math.Pow(favNum, 2);

        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}