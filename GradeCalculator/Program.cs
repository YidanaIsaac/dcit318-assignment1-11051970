using System;

class GradeCalculator
{
    static void Main()
    {
        int grade;

        while (true)
        {
            Console.Write("Enter your numerical grade (0-100): ");
            string input = Console.ReadLine();

            // Try to convert input to an integer safely
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                break; // valid number, exit loop
            }
            else
            {
                Console.WriteLine("❌ Invalid input. Please enter a number between 0 and 100.");
            }
        }

        if (grade >= 90)
            Console.WriteLine("Letter Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Letter Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Letter Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Letter Grade: D");
        else
            Console.WriteLine("Letter Grade: F");
    }
}
