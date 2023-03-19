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
        /// The Id from the database that will be used to identify the winnder.
        /// </summary>
        public int WinnderId { get; set; }
        /// <summary>
        /// Who is the winner in the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// The round number in the tournament.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName 
        {
            get 
            {
                string output = "";

                foreach (MatchupEntryModel entryModel in Entries)
                {
                    if(entryModel.TeamCompeting != null)
                    {
                        if(output.Length == 0)
                        {
                            output = entryModel.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {entryModel.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
