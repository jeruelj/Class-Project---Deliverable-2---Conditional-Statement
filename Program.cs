using System;

namespace Class_Project___Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the anticpated grade to be earned from the course.");

            string input = Console.ReadLine();
            
            int grade = int.Parse(input);

            if (grade >= 98)
            {
                Console.WriteLine("You have earned the letter grade of A+");
            }
            else if (grade >= 92 )
            {
                Console.WriteLine("You have earned the letter grade of A");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("You have earned the letter grade of A-");
            }
            else if (grade >= 88)
            {
                Console.WriteLine("You have earned the letter grade of B+");
            }
            else if (grade >= 82)
            {
                Console.WriteLine("You have earned the letter grade of B");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You have earned the letter grade of B-");
            }
            else if (grade >= 78)
            {
                Console.WriteLine("You have earned the letter grade of C+");
            }
            else if (grade >= 72)
            {
                Console.WriteLine("You have earned the letter grade of C");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You have earned the letter grade of C-");
            }
            else if (grade >= 68)
            {
                Console.WriteLine("You have earned the letter grade of D+");
            }
            else if (grade >= 62)
            {
                Console.WriteLine("You have earned the letter grade of D");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You have earned the letter grade of D-");
            }
            else if (grade < 60)
            {
                Console.WriteLine("You have earned the letter grade of F");
            }
        }
    }
}
