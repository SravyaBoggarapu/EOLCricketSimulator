using System;
using System.Collections.Generic;

namespace EOLCricketSimulator
{
    public class Player
    {
        public int NumberBalls { get; set; }
        public bool IsOut { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public int Order { get; set; }
        public List<Tuple<int, int>> RunsProbability { get; set; }
    }
}
