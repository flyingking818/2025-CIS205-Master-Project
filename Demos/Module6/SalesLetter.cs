/*
 Create a program named SalesLetter whose Main() method uses several 
WriteLine() calls to display a sales letter to prospective clients for
a business of your choice. Display your contact information at least 
three times in the letter. The contact information should contain at 
least three lines with data such as land line phone number and/or 
cellphone number, email address, and web address.. Each time you want 
to display the contact information, call a method named DisplayContactInfo().
 */


using System;
using System.Globalization;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

class SalesLetter
{
    //Our calling method is named the Main() and our called method is named
    //DispalyContactInfo() using synchronous processing (vs. asynchronous calls)
    static void Main()
    {
        WriteLine("From");
        DisplayContactInfo();  //call/invoke/trigger the method

        WriteLine("____________________________\n");
        WriteLine("Dear Client,");
        WriteLine("We want to provide you good service.");
        WriteLine("Feel free to contact us at any time.");

        DisplayContactInfo();
        WriteLine("     *********\n");
        WriteLine("Looking forward to a long relationship.");

        DisplayContactInfo();


        //NEVER USE EMBEDDED METHODS!

    }

    // void means no return value expected.
    // static means we can call this method without object instantiation.
    public static void DisplayContactInfo()
    {
        WriteLine("C# Company");
        WriteLine("Phone: 555 - 1234     Cell: 555 - 0912");
        WriteLine("Email: csharpcompany @csharp.com");
        WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}

