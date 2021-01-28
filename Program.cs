using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            try
            {
                string input = Console.ReadLine();

                int grade = int.Parse(input);

                if ((grade < 60) && (grade >= 0))
                {
                    Console.WriteLine("Your letter grade is F.");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("Your letter grade is D-.");
                }
                else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("Your letter grade is D.");
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("Your letter grade is D+.");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Your letter grade is C-.");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Your letter grade is C.");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Your letter grade is C+.");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Your letter grade is B-.");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Your letter grade is B.");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Your letter grade is B+.");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Your letter grade is A-.");
                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Your letter grade is A.");
                }
                else if ((grade >= 98) && (grade < 100))
                {
                    Console.WriteLine("Your letter grade is A+.");
                }
                else if (grade < 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                    Console.WriteLine("Press any key to close window and restart the program.");
                }
            }
            catch
            {
                Console.WriteLine("Please Enter a positive integer.");
            }
        }
    }
}
