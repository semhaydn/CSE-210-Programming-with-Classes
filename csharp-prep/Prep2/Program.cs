using System;

class Program
{
    static void Main(string[] args)
    {

        //This is prep2
        Console.Write("What is Your Grade: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
    
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        string grade;

        if (x >= a )
        {
            grade = ("A");
        }
        else if (x >= b)
        {
            grade = ("B");
        }
        else if (x >= c)
        {
            grade = ("C");   
        }
        else if (x >= d)
        {
            grade = ("D");
        }
        else
        {
            grade = ("F");
        }
        Console.WriteLine($"Your grade is {grade}");

    }
}