using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
    static void Main()
    {
        //1. Declare variables/constants
        const int CAT1 = 74;
        const int CAT2 = 96;
        const int CAT3 = 111;
        const int CAT4 = 130;
        const int CAT5 = 157;

        //Pretty sure it will be assigned through the input
        int windSpeed;

        //If it's going to be assigned in a decision making structure
        //we need inititize it.
        int category = 0;


        //2. Input procedure (I)
        Write("Please enter a wind speed: ");
        windSpeed = Convert.ToInt32(ReadLine());


        //3. Processing (P) - classification
        //Technique recommended - top down approach by checking 
        //the lower bound ONLY! :)

        //Option 1. Nested IFs
        /*
        if (windSpeed >= CAT5)
            category = 5;
        else
            if (windSpeed >= CAT4)
                category = 4;
            else
                if (windSpeed >= CAT3)
                    category = 3;
                else
                    if (windSpeed >= CAT2)
                        category = 2;
                    else
                        if (windSpeed >= CAT1)
                            category = 1;
                        else
                            category = 0;
        */

        //Option 2 - Optimize the code with elseif
        //This is faster! :)

        /*
        if (windSpeed >= CAT5)
            category = 5;
        else if (windSpeed >= CAT4)
            category = 4;
        else if (windSpeed >= CAT3)
            category = 3;
        else if (windSpeed >= CAT2)
            category = 2;
        else if (windSpeed >= CAT1)
            category = 1;
        else
            category = 0;
        */





        //4. Output (O) - needs to match the client's specs!
        //Conditional out
        if (category == 0)
        {
            WriteLine("This is not a hurricane.");
        }
        else {
            WriteLine($"This is a category {category} hurricane");        
        }
    }
}