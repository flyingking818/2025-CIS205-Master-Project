using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
    static void Main()
    {
        const double RAISE = 0.04;
        //double salary1 = 25000, salary2 = 38000, salary3 = 51000;
        double salary1, salary2,salary3;

        //Input procedures (I)
        Write("Please enter the salary for the first employee: ");
        salary1 = Convert.ToDouble(ReadLine());

        Write("...and the second employee: ");
        salary2 = Convert.ToDouble(ReadLine());

        Write("...and the third employee: ");
        salary3 = Convert.ToDouble(ReadLine());

        //Processing (P)
        //salary1 = salary1 + salary1 * RAISE;
        salary1 = salary1*(1 + RAISE);  //this is the generic logic for increase scenario
        salary2 = salary2 * (1 + RAISE);
        salary3 = salary3 * (1 + RAISE);

        //Output (O)

        WriteLine("Next year's salary for the first employee will be {0}", salary1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the second employee will be {0}", salary2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the third employee will be {0}", salary3.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        //Interpoliation examples:
        WriteLine($"Next year's salary for the first employee will be {salary1.ToString("C",CultureInfo.GetCultureInfo("en-US"))}");
        WriteLine($"Next year's salary for the first employee will be {salary2.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        WriteLine($"Next year's salary for the first employee will be {salary3.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");

        //Simplified examples:
        WriteLine($"Next year's salary for the first employee will be {salary1.ToString("C")}");
        WriteLine($"Next year's salary for the first employee will be {salary1.ToString("C")}");
        WriteLine($"Next year's salary for the first employee will be {salary1.ToString("C")}");

        //Without the dollar symbol
        WriteLine($"Next year's salary for the first employee will be {salary1.ToString("N2")}");

    }
}