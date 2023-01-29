namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents the place a team should take to get the price.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// A title like "the best attacker in the game"
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// How much money is given for the place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// If PrizeAmount is not set, percentage can be used instead.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
