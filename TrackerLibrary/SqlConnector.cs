using TrackerLibrary.Model;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the method actually save to the database.
        /// <summary>
        /// Saves a new prize to the sql database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including id.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
