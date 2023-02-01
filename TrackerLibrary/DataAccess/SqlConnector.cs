using Dapper;
using System.Data;
using System.Net.Http.Headers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        // TODO - Make the method actually save to the database.
        /// <summary>
        /// Saves a new prize to the sql database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including id.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }
    }
}
