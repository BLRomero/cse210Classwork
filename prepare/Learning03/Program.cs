using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");


        // this is an object instantiation I am creating and instance(or object) of a class) 
        // f1 variable name
        // new keyword to create new instance
        //Fraction()constructor call
        Fraction f1 = new Fraction();
        // these are the getters 👇   hence GET.....
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // this is an object instantiation I am creating and instance(or object) of a class)   
         // f1 variable name
        // new keyword to create new instance
        //Fraction(5)constructor call
        Fraction f2 = new Fraction(5);
        // these are the getters 👇   hence GET.....
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // this is an object instantiation I am creating and instance(or object) of a class)
        Fraction f3 = new Fraction(3,4);
        // these are the getters 👇  hence GET.....
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        // this is an object instantiation I am creating and instance(or object) of a class)
        Fraction f4 = new Fraction(1,3);
         // these are the getters 👇  hence GET.....
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}