using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Globalization;
using System.ComponentModel.Design;

namespace CIS205_Master_Project.Demo.Chapter5
{
    class HomeSalesTest
    {
        static void Main()
        {
            //Declare variables
            char letter;           
            double sale, dTotal = 0, eTotal = 0, fTotal = 0, grandTotal;

            //Get initial inputs (D - Danielle, E - Edward, F - Francis)
            Write("Enter a salesperson initial (D, E or F) >> ");           
            letter = Convert.ToChar(ReadLine());

            //While loop to process totals
            while (letter != 'Z' && letter != 'z')
            {
                //if 
                if (letter != 'd' && letter != 'D' && letter != 'e' && letter != 'E' && letter != 'f' && letter != 'F')
                {
                    WriteLine("Please enter a valid initial");
                }
                else
                {
                    Write("Enter amount of sale >> ");                   
                    sale = Convert.ToDouble(ReadLine());

                    //this would help you with the GPA calculator! :)
                    if (letter == 'd' || letter == 'D')
                        dTotal += sale;
                    else if (letter == 'e' || letter == 'E')
                        eTotal += sale;
                    else
                        fTotal += sale;

                    /* similar structure for the GPA calculator
                    if (letter == 'A' || letter == 'a')
                        totalPoints += A_POINT * hours;
                    else if (letter == 'B' || letter == 'b')
                        totalPoints += B_POINT * hours;
                    else if ...

                    totalHours += hours;
                    */

                    // or use a switch block

                    //switch (letter)
                    //{
                    //    case 'd':
                    //    case 'D':
                    //        dTotal += sale;
                    //        break;
                    //    case 'e':
                    //    case 'E':
                    //        eTotal += sale;
                    //        break;
                    //    case 'f':
                    //    case 'F':
                    //        fTotal += sale;
                    //        break;
                    //    default:
                    //        break;
                    //}
                }

                Write("Enter next salesperson intital or Z to quit >> ");               
                letter = Convert.ToChar(ReadLine());
            }

            WriteLine("Danielle sold    {0,10}", dTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Edward sold      {0,10}", eTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Francis sold     {0,10}", fTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            grandTotal = dTotal + eTotal + fTotal;
            WriteLine("Total sales were {0,10}", grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));


            if (dTotal > eTotal && dTotal > fTotal)
                WriteLine("Danielle sold the most");
            else if (eTotal > dTotal && eTotal > fTotal)
                WriteLine("Edward sold the most");
            else if (fTotal > dTotal && fTotal > eTotal)
                WriteLine("Francis sold the most");
            else
                WriteLine("There was a tie");
        }
    }
}
