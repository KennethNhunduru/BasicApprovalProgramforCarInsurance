using System;

namespace BasicApprovalProgramforCarInsurance
{
    class BooleanLogicAssignment
    {
        static void Main(string[] args)
        {
            //Asking the applicant some input questions.

            //What is your age?
            Console.WriteLine("What is your age?");
            Console.WriteLine("Enter your age: ");
            //creating an integer variable, capturing the applicant's string input from the keyboard, and storing it.
            int applicantAge = Convert.ToInt32(Console.ReadLine());

            //Have you ever had a Driving Under the Influence (DUI) conviction?
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("Enter True or False: ");
            //creating an bool variable, capturing the applicant's string input from the keyboard, and storing it.
            bool applicantDUI = Convert.ToBoolean(Console.ReadLine());

            //How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine("Enter your answer: ");
            //creating an integer variable, capturing the applicant's string input from the keyboard, and storing it.
            int applicantSpeedingTickets = Convert.ToInt32(Console.ReadLine());

            //Printing the result of the boolean expression created from the above business rules.
            Console.WriteLine("Is the applicant qualified for Car Insurance: ");

            //Applying the qualification rules to determine if the applicant qualifies for car insurance:
            //creating a boolean qualification variable, implementing the boolean logic and storing the determination.
            
            bool isQualified = (applicantAge > 15) && (applicantSpeedingTickets <= 3) && (!applicantDUI);
            Console.WriteLine(isQualified);

            Console.ReadLine();
        }
    }
}
