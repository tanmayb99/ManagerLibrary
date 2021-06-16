using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLibrary
{
    class MatchPairUpClass
    {
        public List<MatchPairUpEntryClass> Entries { get; set; } = new List<MatchPairUpEntryClass>();
        public TeamClass Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
