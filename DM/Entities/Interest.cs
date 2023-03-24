using DM.Entities;

namespace DM
{
    /// <summary>
    ///     User hobbies or interests
    /// </summary>
    public class Interest:IEntity
    {
        /// <summary>
        ///     interest id
        /// </summary>

        public Guid Id { get; set; }

        /// <summary>
        ///    User entity 
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        ///     user id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        ///     interest description
        /// </summary>
        public string InterestDescription { get; set; }
    }
}