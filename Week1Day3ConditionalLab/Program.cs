using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_3___Conditional_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // SECTION ONE: INCOME TAX CALCULATOR
            //Initialize values and set up arrays
            int[] tier = new int[] { 20000, 50000, 75000 };
            decimal[] rates = new decimal[] { .05M, .1M, .2M, .35M };
            int[] taxAmount = new int[] { 1000, 4000, 9000 };
            decimal taxOwed = 0;
            int income = 0;
            bool isNum = false;

            // Introduce program.
            Console.WriteLine("Welcome to the Income Tax Calculator");
            Console.WriteLine("Please enter your annual income:");

            // This line checks for input to make sure it is an integer and, if it is, it sets it to income
            isNum = int.TryParse(Console.ReadLine(), out income);

            // Calculate taxes of 20,000 or less.
            if (isNum && income > 0)
            {
                if (income <= tier[0])
                    taxOwed = income * rates[0];
                // Calculate taxes of 20,000-50,000.
                else if (income <= tier[1] && income > tier[0])
                    taxOwed = (income - tier[0]) * rates[1] + taxAmount[0];
                // Calculate taxes of 50,000-75,000.
                else if (income <= tier[2] && income > tier[1])
                    taxOwed = (income - tier[1]) * rates[2] + taxAmount[1];
                // Calculate taxes greater than 75,000.
                else if (income > tier[2])
                    taxOwed = (income - tier[2]) * rates[3] + taxAmount[2];
            }
            //If the input is not a positive integer, thi error message will be displayed.
            else
                Console.WriteLine("Invalid input. You must enter a whole number greater than 0");

            // State results.
            if (income > 0)
                Console.WriteLine("Your taxes are $" + taxOwed);

            // End the program.
            Console.ReadLine();

            // SECTION TWO: TIME AND CLASSIFICATIONS
            // Introduces the program.
            Console.WriteLine("Welcome to the Time Classification Tool!");
            Console.WriteLine("Press ENTER to see how the minute is progressing.");
            Console.ReadLine();

            string userInput = "";
            while (userInput == "")
            {
                // Find the current date and time.
                System.DateTime rightNow = new System.DateTime();
                rightNow = DateTime.Now;
                int seconds = DateTime.Now.Second;


                // Print current time
                Console.WriteLine("Current Second:" + rightNow.Second);

                // This swith looks at the current second and returns varying descriptions based on the result.
                switch (seconds)
                {
                    case 0:
                        Console.WriteLine("The new minute is just beginning");
                        break;
                    case 15:
                        Console.WriteLine("We're one quarter done");
                        break;
                    case 30:
                        Console.WriteLine("Halfway there");
                        break;
                    case 45:
                        Console.WriteLine("Getting close to done");
                        break;
                    default:
                        Console.WriteLine("Working on it");
                        break;
                }
                Console.WriteLine("To check the time again press ENTER. To stop press any key then press enter");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }
}