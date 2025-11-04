using System;
using static System.Console;

class ArrayDemo
{
    //Let's build the menu options
    enum Menu
    {
        IN_ORIGINAL_ORDER = 1,
        REVERSE_ORDER,
        SPECIFIC_POSITION,
        QUIT
    }

    static void Main()
    {
        //Declare the array object
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        int pos = 1;
        int option;

        //The traditional indefinite loop

        //Display the menu
        WriteLine("Please select an option: ");
        foreach (string menuOption in Enum.GetNames(typeof(Menu)))
        {
            WriteLine($"{pos} {menuOption}");
            pos++;
        }

        Write("         >>>>");
        option = Convert.ToInt32(ReadLine());

        //Processing (P) -> handle the user selection accordingly. 

        while(option!= (int)Menu.QUIT)
        {
            if (option == (int)Menu.IN_ORIGINAL_ORDER)
            {
                for (int x = 0; x < nums.Length; ++x)
                {
                    Write($"{nums[x],5}");
                }
            }
            else if (option == (int)Menu.REVERSE_ORDER)
            {
                for (int x = nums.Length - 1; x >= 0; --x)
                {
                    Write($"{nums[x],5}");
                }
            }
            else if (option == (int)Menu.SPECIFIC_POSITION)
            {
                Write("Enter position (starting with 0) >> ");
                pos = Convert.ToInt32(ReadLine());
                WriteLine($"Number in position {pos} is {nums[pos]}");
            }
            else
            {
                WriteLine("****** Sorry — invalid option");
            }
            WriteLine("\nChoose one:");
            pos = 1;
            foreach (string menuOption in Enum.GetNames(typeof(Menu)))
            {
                WriteLine($"{pos}  {menuOption}");
                ++pos;
            }
            Write("                 >> ");
            option = Convert.ToInt32(ReadLine());
        }



    }
}
