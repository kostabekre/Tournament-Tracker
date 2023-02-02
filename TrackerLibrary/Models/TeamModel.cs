namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents how the team is called.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents the people who are in this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
