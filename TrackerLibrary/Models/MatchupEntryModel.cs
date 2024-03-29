﻿namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The unique identifier for the team.
        ///</summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in match up.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        ///<summary>
        /// The unique identifier for the ParentMatchup
        ///</summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
