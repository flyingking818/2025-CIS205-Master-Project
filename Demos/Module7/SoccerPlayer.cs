using System;
using static System.Console;
using System.Globalization;
class TestSoccerPlayer
{
    static void Main()
    {
        //Implementation of the SoccerPlayer class
        SoccerPlayer mySoccerPlayer = new SoccerPlayer();
        mySoccerPlayer.Name = "Lionel Messi";
        mySoccerPlayer.JerseyNum = 10;
        mySoccerPlayer.Goals = 900;
        mySoccerPlayer.Assists = 500;
        WriteLine("The SoccerPlayer is {0}. Jersey is #{1}.", mySoccerPlayer.Name, mySoccerPlayer.JerseyNum);
        WriteLine("Goals: {0}. Assists: {1}.", mySoccerPlayer.Goals, mySoccerPlayer.Assists);

        SoccerPlayer anotherSoccerPlayer = new SoccerPlayer();
        anotherSoccerPlayer.Name = "Ronaldo";
        anotherSoccerPlayer.JerseyNum = 7;
        anotherSoccerPlayer.Goals = 950;
        anotherSoccerPlayer.Assists = 300;
        WriteLine("The SoccerPlayer is {0}. Jersey is #{1}.", anotherSoccerPlayer.Name, anotherSoccerPlayer.JerseyNum);
        WriteLine("Goals: {0}. Assists: {1}.", anotherSoccerPlayer.Goals, anotherSoccerPlayer.Assists);

    }
}

class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNum { get; set; }
    public int Goals { get; set; }
    public int Assists { get; set; }
}