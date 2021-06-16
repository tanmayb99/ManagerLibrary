using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLibrary
{
    class MatchPairUpEntryClass
    {
        /// <summary>
        /// This represents one team in the match pair up.
        /// </summary>
        public TeamClass TeamCompeting { get; set; }

        /// <summary>
        /// This represents the score of this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// This represents the match pair up from which this team emerged as the winner.
        /// </summary>
        public MatchPairUpClass ParentMatchPairUp { get; set; }
    }
}
