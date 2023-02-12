namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Two teams that compete with each other.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Who is the winner in the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The round number in the tournament.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
