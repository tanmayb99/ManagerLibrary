using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLibrary
{
    class TournamentClass
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamClass> EnteredTeams { get; set; } = new List<TeamClass>();
        public List<PrizeClass> Prizes { get; set; } = new List<PrizeClass>();
        public List<MatchPairUpClass> Rounds { get; set; } = new List<MatchPairUpClass>();
    }
}
