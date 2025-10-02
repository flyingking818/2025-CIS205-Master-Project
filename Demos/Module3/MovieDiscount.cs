using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module3
{
    internal class MovieDiscount
    {
        static void Main()
        {
            const int CHILD_AGE = 12;  //lower bound for child (exclusive-- <)
            const int SENIOR_AGE = 65; //upper bound for senior (inclusive-- >=)

            int age;
            char rating;  //G, P, R, small container for a single character. 
                          //requires single quotes ' '

            //=========Input (I)============
            Write("Please enter your age (e.g, 10): ");
            age = Convert.ToInt32(ReadLine());
            //age = int.Parse(ReadLine()); //alternative way to convert string to int

            Write("Please enter the movie rating (e.g, G or R): ");
            rating = Convert.ToChar(ReadLine());

            //=========Processing (P)============
            //if(age< CHILD_AGE || age >= SENIOR_AGE || rating == 'G') common mistake

            //Option 1 - Best practice
            if((age < CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
            {
                WriteLine("You get a discount!");
            }
            else
            {
                WriteLine("No discount for you!");
            }

            //Option 2 - check the negative condition
            if ((age >= CHILD_AGE && age < SENIOR_AGE) || rating == 'R')
            {
                WriteLine("No discount for you!");                
            }
            else
            {
                WriteLine("You get a discount!");
            }

            //Option 3 - Using NOT (!) operator
            if (((age >= CHILD_AGE && age < SENIOR_AGE) || rating == 'R')!=true)
            {
                WriteLine("You get a discount!");                
            }
            else
            {
                WriteLine("No discount for you!");
            }

            //Option 4 

            if ((age < CHILD_AGE && rating == 'G') || (age >= SENIOR_AGE && rating == 'G'))
            {
                WriteLine("You get a discount!");
            }
            else
            {
                WriteLine("No discount for you!");
            }
        }
    }
}
