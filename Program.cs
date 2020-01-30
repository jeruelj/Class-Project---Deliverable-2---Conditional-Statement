using System;

namespace Class_Project___Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter a numeric grade 
            Console.WriteLine("Please enter the anticpated grade to be earned from the course.");

            try
            {


                //Allows the users input to entered to later be matched to a grade earned.
                string input = Console.ReadLine();

                //This section reads the entry of the user. 
                int grade = int.Parse(input);

                //Results based off of user input.
                if (grade > 100)
                {
                    Console.WriteLine("Enter a number within the range of 0 - 100.");
                }
                else if (grade < 0)
                {
                    Console.WriteLine("Enter a number within the range of 0 - 100.");
                }
                else if (grade >= 98)
                {
                    Console.WriteLine("You have earned the letter grade of A+");
                }
                else if (grade >= 92)
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

            catch
            {
                //If the user enters a number out of range or a non integer value. 
                Console.WriteLine("You have entered a value that does not meet the requirement. Please try a value between 1 - 100.");
            }
            }
    }
}
