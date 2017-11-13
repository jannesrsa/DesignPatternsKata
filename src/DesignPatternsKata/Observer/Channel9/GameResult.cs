using System;

namespace DesignPatternsKata.Observer.Channel9
{
    public class GameResult
    {
        public DateTime GameDate { get; set; }

        public int LosingScore { get; set; }

        public string LosingTeam { get; set; }

        public int WinningScore { get; set; }

        public string WinningTeam { get; set; }
    }
}