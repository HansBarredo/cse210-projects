using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Hans Barredo", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Hans Barredo", "Fractions", "Section 7.3", "Problems 8-19" );
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        
        WritingAssignment assignment3 = new WritingAssignment("Hans Barredo", "Fractions", "The Causes of World War II" );
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}