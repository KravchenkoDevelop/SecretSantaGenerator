namespace DM
{
    /// <summary>
    ///     person hobbies or interests
    /// </summary>
    public class Interest
    {
        /// <summary>
        ///     interest id
        /// </summary>

        public Guid Id { get; set; }

        /// <summary>
        ///    person entity 
        /// </summary>
        public virtual User Person { get; set; }

        /// <summary>
        ///     person id
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        ///     interest description
        /// </summary>
        public string InterestDescription { get; set; }
    }
}