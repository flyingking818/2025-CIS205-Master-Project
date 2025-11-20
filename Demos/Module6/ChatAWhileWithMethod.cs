using System;
using static System.Console;
using System.Globalization;
using System.Xml;

class ChatAWhileWithMethod
{
    static void Main()
    {
        string[] area = { "262", "414", "608", "715", "815", "920" };
        double[] price = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

        int i, minutes;
        double total = 0;
        string entryArea;
        bool isFound = false;

        //1. GetAreaCode()
        entryArea = GetAreaCode();

        //2. FindAreaIndex()
        //These two are called arguments.
        int index = FindAreaIndex(area, entryArea);

        //3. Decision making
        // 3.1 -> No match => Write "No found!"), early exit. 
        // 3.1 -> Yes match => 
        if (index == -1)
        {
            WriteLine("Sorry, no match for this area code");
        }
        else
        {
            minutes = GetMinutes();           
            total = CalculateTotal(price[index], minutes);
            DisplayResult(entryArea, price[index], minutes, total);
        }      
    }

    //Standard input methods (you can easily add data validation here)
    static string GetAreaCode()
    {
        Write("What area code you wish to call? ");
        return ReadLine();
    }

    static int FindAreaIndex(string[] area, string entryArea)
    {
        //if there's match return the index, if not, return -1;
        for (int i = 0; i < area.Length; i++)
        {
            if (entryArea == area[i])
            {
                return i; //early exit.
            }
        }
        return -1; //This is commonly used to indicate "no match"!
    }

    static int GetMinutes()
    {
        Write("How many minutes is your call? ");
        return Convert.ToInt32(ReadLine());
    }

    static double CalculateTotal(double rate, int minutes)
    {
        return rate * minutes;
    }

    static void DisplayResult(string area, double rate, int minutes, double total)
    {
        WriteLine($"Your phone call to area {area} costs {rate.ToString("C", CultureInfo.GetCultureInfo("en-us"))} per minute");
        WriteLine($"For {minutes} minutes the total is {total.ToString("C", CultureInfo.GetCultureInfo("en-us"))}");
    }

}
