namespace TrackerLibrary.Model
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents how the tournament is called.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// How much money should a team give to participate in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// All teams that participate in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prizes that the winners will get.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// All rounds in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
