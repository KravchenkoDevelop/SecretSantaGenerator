namespace DM
{
    public class UserData
    {
        /// <summary>
        /// user data id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  users id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        ///  user entity
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        ///     user first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     user last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     user patronym if exists
        /// </summary>
        public string Patronym { get; set; }

        /// <summary>
        ///     user e-mail
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        ///     user living country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        ///     user living  region
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        ///     user living city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///     user address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     user PostalCode
        /// </summary>
        public string PostalCode { get; set; }

    }
}
