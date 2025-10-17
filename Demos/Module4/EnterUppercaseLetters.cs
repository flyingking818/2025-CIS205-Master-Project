using System;
using static System.Console;
using System.Globalization;
class EnterUppercaseLetters
{
    static void Main()
    {
        // Write your code here
        //Declaration
        const char QUIT = '!';  //This is the sentinel value,
                                //which can be any characters.

        char letter;  //we don't know yet, so just declare.

        /*

        //Input Procecure (prime outside the while loop)
        Write("Please enter an uppercase letter or ! to stop: ");
        letter = Convert.ToChar(ReadLine());

        //Option 1 - Standard while indefinite loop
        //Check the sentinel value before getting in to the loop
        //Prime the input before checking--> double the input.

        while (letter != QUIT) {
            //check for the range of upper case letters
            //A<=letter<=Z
            //if (letter >= 'A' && letter <= 'Z') {
            if(char.IsLetter(letter) && char.IsUpper(letter)) {
                WriteLine("OK");
            }
            else
            {
                WriteLine("Sorry - that was not an uppercase letter.");
            }

            //IMPORTANT-Reask the user for the sentinel value.
            Write("Please enter an uppercase letter or ! to stop: ");
            letter = Convert.ToChar(ReadLine());
        }

        */

        //Option 2 - Early Exit Indefinite Loop
        //Keep the repetition until we break from the sentinel value
        //The question is only asked once within the loop!
        while (true)
        {
            Write("Please enter an uppercase letter or ! to stop: ");
            letter = Convert.ToChar(ReadLine());

            //Check whether an early exit is required
            if (letter == QUIT)
            {
                break;
            }

            //The main loop body!
            if (char.IsLetter(letter) && char.IsUpper(letter))
            {
                WriteLine("OK");
            }
            else
            {
                WriteLine("Sorry - that was not an uppercase letter.");
            }


        }




    }
}