using TrackerLibrary.Model;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO: Wire up the method for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
