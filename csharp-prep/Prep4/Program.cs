using System;
// add this line to allow for the lists 
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    { 
      
        List<int> numbers = new List<int>();
        
        
        int userNumber = -1;
        while (userNumber != 0)
        {
          
            Console.WriteLine("Enter a number, type 0 when finished");

            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                    numbers.Add(userNumber);

            }

    }
// Write each of the numbers entered: 
        Console.WriteLine("Numbers Entered:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
// Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}" );


// Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
   

// Highest number 
    int maxNumber = numbers.Max();
    Console.WriteLine($"Max Number is: {maxNumber}");
  }
  }