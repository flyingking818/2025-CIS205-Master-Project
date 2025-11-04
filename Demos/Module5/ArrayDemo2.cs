using System;
using static System.Console;

class ArrayDemo2
{
    enum Menu
    {
        IN_ORIGINAL_ORDER = 1,
        REVERSE_ORDER,
        SPECIFIC_POSITION,
        QUIT
    }

    static void Main()
    {
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        int pos = 1;
        int option;

        while (true)
        {
            WriteLine("\nPlease pick one option:");
            pos = 1;
            foreach (string menuOption in Enum.GetNames(typeof(Menu)))
            {
                WriteLine($"{pos}  {menuOption}");
                ++pos;
            }

            Write("         >>>>> ");
            option = Convert.ToInt32(ReadLine());

            if (option == (int)Menu.QUIT)
            {
                WriteLine("Exiting program... Goodbye!");
                break; // Exit the while(true) loop
            }
            else if (option == (int)Menu.IN_ORIGINAL_ORDER)
            {
                WriteLine("\nArray in original order:");
                for (int x = 0; x < nums.Length; ++x)
                {
                    Write($"{nums[x],5}");
                }
                WriteLine();
            }
            else if (option == (int)Menu.REVERSE_ORDER)
            {
                WriteLine("\nArray in reverse order:");
                for (int x = nums.Length - 1; x >= 0; --x)
                {
                    Write($"{nums[x],5}");
                }
                WriteLine();
            }
            else if (option == (int)Menu.SPECIFIC_POSITION)
            {
                Write("Enter position (starting with 0) >> ");
                pos = Convert.ToInt32(ReadLine());

                if (pos >= 0 && pos < nums.Length)
                    WriteLine($"Number in position {pos} is {nums[pos]}");
                else
                    WriteLine("Invalid position entered.");
            }
            else
            {
                WriteLine("****** Sorry — invalid option");
            }
        }
    }
}
