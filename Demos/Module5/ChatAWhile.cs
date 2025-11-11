using System;
using static System.Console;
using System.Globalization;
using System.Xml;
class ChatAWhile
{
    static void Main()
    {
        //Declare two parallel arrays area[] price[]


        string[] area = { "262", "414", "608", "715", "815", "920" }; //This is the key array
        double[] price = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 }; //This is the returning value array

        //1) Two parallel arrays
        //     hint (create nights[] array with brackets)
        //      prices[] to find the matching daily rate
        //2) Try to use reverse calculations (high index->low index), --i (i--)

        int i, minutes;
        double total = 0;
        string entryArea;
        bool isFound = false;  //Once we find a match, we need to get out of the loop.
        //Another option-> use the BinarySearch() method => bonus! :)

        //Input procedure
        Write("What area code you wish to call? ");
        entryArea = ReadLine(); //No conversion needed here since we ask for string.

        //Processing - Loop through the key array to find an EXACT match.               
        //If there's a match, return the corresponding value from the 
        //parallel array, otherwise, return an error message. 

        for ( i = 0; i < area.Length && !isFound; i++)
        {
            if (entryArea == area[i])  //exact match! == NOT =
            {
                Write("How many minutes is your call? ");
                minutes = Convert.ToInt32(ReadLine());

                //Total Cost = P*Q 
                total = price[i] * minutes;
                //grab the corresponding value from the parallel array using
                //the SAME index!
                WriteLine($"Your phone call to area {entryArea} costs {price[i].ToString("C", CultureInfo.GetCultureInfo("en-us"))} per minute");
                WriteLine($"For {minutes} minutes the total is {total.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
                isFound=true;
            }           
        }

        if (!isFound)
        {
            Write($"Sorry - no calls allowed to area {entryArea}.");
        }

    }
}