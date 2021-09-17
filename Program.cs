using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("What letter grade are you expecting to receive in ISM 4300?");
            try
            {
                //Gather input and convert to integer
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                //If 90 is less than or = to grade
                if (90 <= grade)
                {
                    //Displays message with corresponding letter grade
                    Console.WriteLine("You will receive an A in the course!");

                }
                //If 80 is less than or = to grade
                else if ((80 <= grade) && (grade < 90))
                {
                    //Displays message with corresponding letter grade
                    Console.WriteLine("You will receive a B in the course!");
                }
                //If 70 is less than or = to grade
                else if ((70 <= grade) && (grade < 80))
                {
                    Console.WriteLine("You will receive a C in the course.");
                }
                else if ((60 <= grade) && (grade < 70))
                {
                    Console.WriteLine("You will receive a D in the course.");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("You will receive an F in the course");
                }
            }
            //Displays message if input type is invalid
            catch
            {
                Console.WriteLine("Please enter a number between 0 and 100.");
            }
        }
    }
}
