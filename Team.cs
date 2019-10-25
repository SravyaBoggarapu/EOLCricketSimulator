using System;
using System.Collections.Generic;
using System.Text;

namespace EOLCricketSimulator
{
    public class Team
    {
        public Team(int leftOvers, int runsToWin, int remainingWicket)
        {
            LeftOvers = leftOvers;
            RunsToWin = runsToWin;

            RemainingWicket = remainingWicket - 2;
            TotalRuns = 0;
            Players = new List<Player>()
            {
                new Player()
                {
                    Order = 1,
                    Score = 0,
                    NumberBalls =0,
                    IsOut =false,
                    PlayerName ="Pravin",
                    RunsProbability =new List<Tuple<int, int>>
                    {
                       new Tuple<int, int>(5,0),
                       new Tuple<int, int>(30,1),
                       new Tuple<int, int>(25,2),
                       new Tuple<int, int>(10,3),
                       new Tuple<int, int>(15,4),
                       new Tuple<int, int>(1,5),
                       new Tuple<int, int>(9,6),
                       new Tuple<int, int>(5,-1),
                    }
                },
                new Player()
                {
                    Order = 2,
                    Score = 0,
                    NumberBalls =0,
                    IsOut =false,
                    PlayerName ="Irfan",
                    RunsProbability =new List<Tuple<int, int>>
                    {
                       new Tuple<int, int>(10,0),
                       new Tuple<int, int>(40,1),
                       new Tuple<int, int>(20,2),
                       new Tuple<int, int>(5,3),
                       new Tuple<int, int>(10,4),
                       new Tuple<int, int>(1,5),
                       new Tuple<int, int>(4,6),
                       new Tuple<int, int>(10,-1),
                    }
                },
                new Player()
                {
                    Order = 3,
                    Score = 0,
                    NumberBalls =0,
                    IsOut =false,
                    PlayerName ="Jalindar",
                    RunsProbability =new List<Tuple<int, int>>
                    {
                       new Tuple<int, int>(20,0),
                       new Tuple<int, int>(30,1),
                       new Tuple<int, int>(15,2),
                       new Tuple<int, int>(5,3),
                       new Tuple<int, int>(5,4),
                       new Tuple<int, int>(1,5),
                       new Tuple<int, int>(4,6),
                       new Tuple<int, int>(20,-1),
                    }
                },
                new Player()
                {
                    Order = 4,
                    PlayerName ="Vaishali",
                    Score = 0,
                    NumberBalls =0,
                    IsOut =false,
                    RunsProbability =new List<Tuple<int, int>>
                    {
                       new Tuple<int, int>(30,0),
                       new Tuple<int, int>(25,1),
                       new Tuple<int, int>(5,2),
                       new Tuple<int, int>(0,3),
                       new Tuple<int, int>(5,4),
                       new Tuple<int, int>(1,5),
                       new Tuple<int, int>(4,6),
                       new Tuple<int, int>(30,-1),
                    }
                },
            };
            Striker = Players[0];
            Runner = Players[1];
        }

        public Player Striker { get; set; }
        public Player Runner { get; set; }

        public int TotalRuns { get; set; }

        public int LeftOvers { get; set; }

        public int RunsToWin { get; set; }

        public int RemainingWicket { get; set; }

        public List<Player> Players { get; set; }
    }
}
