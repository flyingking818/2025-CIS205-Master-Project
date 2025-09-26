using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module3
{
    internal class GuessingGame
    {
        static void Main()
        {
            //write up your processes.
            //1. Declaration of variables and constants
            const int MIN = 1; //inclusive
            const int MAX = 11; //non-inclusive (next number)
            
            int randomNum;  //random class generates this
            int guess;      //via user input
            string result=""; //if we wish to use an outcome variable to store the result.


            //2. Get input from the user (or this can be step 3)
            //Prompt
            //ReadLine()  - usually involves data conversion

            Write("Please enter your guess (e.g., 8): ");
            guess = Convert.ToInt32(ReadLine());

            //3. Generate the random number
            Random random = new Random();  //Create a concreate random object based on the 
                                            //random classs (instantiation)
            randomNum = random.Next(MIN, MAX);

            //4. Decision-making process by comparing the numbers

            //Option 1 - Nested IFs
            //Use nested if - if one condition depends on another (hierarchical checks)
            //The number of IFs = Possible Outcomes - 1   => N - 1
            //Don't create nasty IFs!!! no more than 5. 

            if (guess > randomNum)
            {
                //result = "Too high!";  //more elegant
                WriteLine("Too high!");  //more efficient
            }
            else
            {
                if (guess < randomNum)
                {
                    WriteLine("Too low!");
                }
                else
                {
                    WriteLine("Correct!:)");
                }
            }

            //Option 2
            //If the outcomes are mutually exclusive, then we are better off with 
            //if...else if...else

            if (guess > randomNum)
            {
                //result = "Too high!";  //more elegant
                WriteLine("Too high!");  //more efficient
            }
            else if (guess < randomNum)
            {
                WriteLine("Too low!");
            }
            else
            {
                WriteLine("Correct!:)");
            }
           

            //5. Produce meaningful output

            //Write(result);




            //Nested IF example
            /*
                if (age < 18)
                {
                    if (isStudent)
                        WriteLine("Discount applied!");
                    else
                        WriteLine("Sorry, no discount. Must be a student.");
                }
                else
                {
                    WriteLine("Sorry, no discount. Must be under 18.");
                }
            */

        }
    }
}
