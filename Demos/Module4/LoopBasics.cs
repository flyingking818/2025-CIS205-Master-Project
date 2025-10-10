/*
Create a program to print number 1 to 5.
-- definite loop, in which the number of loops is predefined.
 */


using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module4
{
    internal class LoopBasics
    {
        static void Main()
        {
            const int LIMIT = 5; //This is usualy from a .Count property, .Length

            //Option 1 - While Loop, the most flexiable looping structure in C#!

            int i=1;  //the control variable for a while/for loop
                      //i usually starts at 0 (array, list), if so, i<LIMIT
                      //if we start with 1, then, i<=LIMIT!!!
                      //int x; int n;
                      // int counter;
                      // for nested looping i and j

            //exit clause, be careful with the equal sign!!! (in most cases, its non-inclusive)
            while (i <= LIMIT) { 
                WriteLine(i);
                i++;  //self increment i=i+1, post-increment (tradtional)
                //++i;   //pre-increment, this is more modern

               /*
               In Pre-Increment, the operator sign (++) comes before the variable. 
               It increments the value of a variable before assigning it to another variable. 

               In Post-Increment, the operator sign (++) comes after the variable. 
               It assigns the value of a variable to another variable and then increments its value.


              a = 0;
              b = ++a; // b = 1; a = 1

              int a = 0;
              int b = a++; // b = 0; a = 1

              */
            }

            WriteLine("\n");

            int x = 0; //this is more common! 
            while (x <LIMIT)
            {
                WriteLine(x+1);  //we need to offset the index 
                x++;
            }

            WriteLine();
            //Option 2: For Loop, which is preferred for definite loops!
            for (int counter = 0; counter < LIMIT; counter++)  //this is better!
            {
                WriteLine(counter+1);
            }
            WriteLine();
            for (int counter = 1; counter <= LIMIT; counter++)
            {
                WriteLine(counter);
            }

            //Option 3: Foreach loop (great with object, lists, arrays, items, etc.)
            //Declare an array to contain 5 numbers

            WriteLine();
            int[] numbers = {1,2,3,4,5};

            foreach (int num in numbers)
            {
                WriteLine(num);
            }

            //Indefinite Loop (count is not known)
            WriteLine("Type 'exit' to stop the loop.\n");

            string input = ""; // initialize before the loop
            while (input.ToLower() != "exit")
            {
                Write("Enter something: ");
                input = ReadLine();

                if (input.ToLower() != "exit")
                    WriteLine($"You entered: {input}");
            }

            WriteLine("Exiting the loop... Goodbye!");

        }        
    }

    //MindTap Demo
    class SumInts
    {
        static void Main()
        {
            int num, sum = 0;
            const int STOP = 999;

            Write("Enter a number >> ");
            num = Convert.ToInt32(ReadLine());
            while (num != STOP)
            {
                sum += num;
                Write("Enter another number or {0} to quit >> ", STOP);
                num = Convert.ToInt32(ReadLine());
            }
            WriteLine("\n                             The sum is {0}", sum);
        }
    }

}




