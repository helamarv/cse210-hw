using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What was your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letterGrade = "";

        /*GRADE SIGN   +|| ||- */
        int gradePercentageRemainder = gradePercentage / 10;
        Console.WriteLine("");
        string gradeSign = "";

        if (gradePercentageRemainder >= 7)
        {
            gradeSign = "+";
        }
        else if (gradePercentageRemainder <= 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }


        /*LETTER GRADE*/
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            Console.WriteLine($"You received an {letterGrade}{gradeSign}.");
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
            Console.WriteLine($"You received an {letterGrade}{gradeSign}.");
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
            Console.WriteLine($"You received an {letterGrade}{gradeSign}.");
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
            Console.WriteLine($"You received an {letterGrade}{gradeSign}.");
        }
        else
        {
            letterGrade = "F";
            Console.WriteLine($"You received an {letterGrade}{gradeSign}.");
        }

        /*PASS OR NOT*/
        Console.WriteLine();
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}