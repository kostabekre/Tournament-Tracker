using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PersonModel CreatePerson(PersonModel model);
        PrizeModel CreatePrize(PrizeModel model);
        TeamModel CreateTeam(TeamModel model);
        List<PersonModel> GetPerson_All();
    }
}
