/*
 Compare a number again a threshold - 10
1) Ask the user to give you a number (int)
2) If number is bigger than the threshold, say 
    The XXX is greater than THRESHOLD
   Else
    The XXX is NOT greater (<=) than THRESHOLD.

 */



using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module3
{
    internal class IfElseDecision
    {
        static void Main()
        {
            //Hints
            //Declaration (constant? variables?)
            const int HIGH = 10;
            int number; //if we are confident that the number is gonna be assigned, 
            //only declaration is need. Otherwise, we need to initialize.


            //Input procedure 
            Write("Please enter a number (e.g., 8): ");
            number = int.Parse(ReadLine());

            //Decision making
            if (number > HIGH) 
                WriteLine($"{number} is greater than {HIGH}");
            else
                WriteLine($"{number} is NOT greater (<=) than {HIGH}");

        }
    }
}
