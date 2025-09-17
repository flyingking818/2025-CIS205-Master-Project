using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module2
{
    internal class Eggs
    {
        public static void Main()
        {
            //1. Input (I)
            //Declare and initialize variables
            const int DOZENS = 12;

            //Never use hard-coded values in your calculations!
            //Let's make this interactive! :)
            //int chicken1 = 30, chicken2 = 20, chicken3 = 40, chicken4 = 25;

            int chicken1, chicken2, chicken3, chicken4;
            int total;
            int dozens, leftOver;


            //Input Procedures (prompt and read)
            Write("Please enter the number of eggs from chicken 1: (e.g., 10) ");
            chicken1 = Convert.ToInt32(ReadLine());  //potentially unsafe

            Write("Please enter the number of eggs from chicken 2: ");
            chicken2 = Convert.ToInt32(ReadLine());

            Write("Please enter the number of eggs from chicken 3: ");
            chicken3 = Convert.ToInt32(ReadLine());

            Write("Please enter the number of eggs from chicken 4: ");
            chicken4 = Convert.ToInt32(ReadLine());

            //Processing (P)
            total = chicken1 + chicken2 + chicken3 + chicken4;
            dozens = total / DOZENS;    //the int type automatically truncates the decimal
            leftOver = total % DOZENS;  //the modulus operator gives the remainder

            //Output (O)
            //Option 1 - placeholders
            WriteLine("A total of {0} eggs is {1} dozen and {2} eggs.", total, dozens, leftOver);

            //Option 2 - string interpolation (recommended!)
            WriteLine($"A total of {total} eggs is {dozens} dozen and {leftOver} eggs.");

            ReadKey();

        }
    }
}
