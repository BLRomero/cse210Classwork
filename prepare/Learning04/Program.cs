using System;

class Program
{
    static void Main(string[] args)
    {
        // assignment1 name and topic **no inheritance
         Console.WriteLine("Assignment 1 no inheritance");
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Jackson");
        assignment1.SetTopic("Fractions");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();


        // assignment2 name, topic, section and problems 
        // **Inheritance present
        Console.WriteLine("Assignment 2 inheritance present");
        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Justin Nelson");
        assignment2.SetTopic("Multiplication");
        assignment2.SetTextbookSection("7.3");
        assignment2.SetProblems("6-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();


        // Using Assignment Default constructor 
         Console.WriteLine("Assignment 3 assignment default constructor");
        Assignment assignment3 = new Assignment();
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine();


        // using the constructor MathAssignment()
         Console.WriteLine("Assignment 4 mathassignment constructor");
        MathAssignment assignment4 = new MathAssignment();
        Console.WriteLine(assignment4.GetSummary());
        Console.WriteLine(assignment4.GetHomeworkList());
        Console.WriteLine();


        // using Assignment Construtor with 2 paramaters studentName and tpoic
         Console.WriteLine("Assignment 5 assignment ocnstructor with 2 params");
        Assignment assignment5 = new Assignment("Jessica Martin", "Division");
        Console.WriteLine(assignment5.GetSummary());
        Console.WriteLine();


        // using Math assignment Constructor with 4 parametes studentName, topic, textbookSection, and problems
         Console.WriteLine("Assignment 6 math assignment base constructor with 4 params");
        MathAssignment assignment6 = new MathAssignment("Eli Alvarez", "Subtraction", "2.2", "1-10");
        Console.WriteLine(assignment6.GetSummary());
        Console.WriteLine(assignment6.GetHomeworkList());
        Console.WriteLine();

        // using  Writing Assignment deafult constructor
         Console.WriteLine("Assignment 7 writing assignment default constructor");
        WritingAssignment assignment7 = new WritingAssignment();
         assignment7.SetStudentName("Abby Contreras");
        assignment7.SetTopic("European History");
        Console.WriteLine(assignment7.GetSummary());
        Console.WriteLine();

        // using Writing assignment Constructor with 3 parametes studentName, topic, title
         Console.WriteLine("Assignment 8 writing assignment base constructor with 3 params");
        WritingAssignment assignment8 = new WritingAssignment("Denise Contreras", "American History", "The civil war by MJ Jackson");
        Console.WriteLine(assignment8.GetSummary());
        Console.WriteLine(assignment8.GetWritingInfo());
        Console.WriteLine();

    }
}