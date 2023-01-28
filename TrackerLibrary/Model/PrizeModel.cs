namespace TrackerLibrary.Model
{
    public class PrizeModel
    {
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
    }
}
