using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module3
{
    internal class StateDiscount
    {
        static void Main()
        {
            double purchasePrice;
            string stateCode;
            double discountState;
            double salePrice;  //salePrice = purchasePrice*(1-discountRate)
            bool isFlaglerStudent; //More discount

            //Input 
            Write("Please enter your price: ");
            purchasePrice = double.Parse(ReadLine());

            Write("Please enter your state code (e.g., FL): ");
            stateCode = ReadLine();

            Write("Are you a Flagler student (e.g., True or False)? ");
            isFlaglerStudent = Convert.ToBoolean(ReadLine());

            //Processing (P) - using Switch...Case block

            switch (stateCode)
            {
                //"Fl"=>discountState = 0.15;
                case "FL":                   
                    //nest if   ...swtich...if combo
                    if (isFlaglerStudent)  //boolean contains T/F already.
                    {
                        discountState = 0.15;
                    }
                    else
                    {
                        discountState = 0.10;
                    }
                    break;
                case "NE":
                case "CA":
                    discountState = 0.13;
                    break;
                case "MD":
                    discountState = 0.08;
                    break;
                case "OH":
                    discountState = 0.06;
                    break;
                default:
                    discountState = 0.00;
                    break;
            }

            salePrice = purchasePrice* (1-discountState);  //decrease scenario! :)

            WriteLine($"Your state discount is {discountState.ToString("P")} and the sale price is {salePrice.ToString("C")}");
               


        }
    }
}
