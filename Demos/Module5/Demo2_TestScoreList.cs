/*
    Write a program named TestScoreList that accepts eight int values representing student test scores. 
    Display each of the values along with a message that indicates how far it is from the average. 
 */



using System;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        int[] scores = new int[8];  //.Length = 8  upper bound = 7, lower bound=0
        int testNum;  //index number
        double total = 0;  //subtotal for all student scores
        double avg;  //avg = total/length

        //Input procedure for a fixed array
        for (testNum = 0; testNum < scores.Length; ++testNum)
        {
            Write("Please enter score for test number {0} >> ", (testNum + 1));
            scores[testNum] = Convert.ToInt32(ReadLine());//assignment for array element.
            total += scores[testNum]; //accumulative subtotal

        }
        //Do this outside of the loop
        avg = total / scores.Length;  //  = total/sample size

        //Output, finding the spread of observations from the mean (dispersion)
        WriteLine("Scores for the tests are:");
        for (testNum = 0; testNum < scores.Length; ++testNum) 
        { 
            WriteLine("Test # {0}: {1, 5} From average: {2, 5}", testNum,
              scores[testNum].ToString(), (scores[testNum] - avg).ToString());
        }
        WriteLine("\n  Total is {0, 5}", total.ToString());
        WriteLine("Average is {0, 5}", avg.ToString());
    }
}
