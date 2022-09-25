namespace DM.Models
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
        ///     binding person
        /// </summary>
        public virtual Person Person { get; set; }

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