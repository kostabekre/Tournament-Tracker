using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePerson(PersonModel model);
        void CreatePrize(PrizeModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void CompleteTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel matchup);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournaments_All();
    }
}
