namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The person's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The person's last name.
        /// </summary>
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        /// <summary>
        /// The email address to contact the person.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The phone number to cantact the person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
