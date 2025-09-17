using System;
using static System.Console;

namespace CIS205_Master_Project.Assignments.Project1
{
    internal class FavoriteSayingDisplay
    {
        static void Main(string[] args)
        {
            //Change the console properties
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Green;
            Clear();


            WriteLine("Output #1");
            Write("\tWork hard, ");
            Write("play ");
            Write("hard! :)");

            WriteLine("\n");
            WriteLine("Output #2");
            Write("\tWork hard, \n");
            Write("\tplay \n");
            Write("\thard! :-)\n");
        }
    }
}
