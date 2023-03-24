using DM.Entities;
using UserDM.Enums;

namespace DM
{
    /// <summary>
    ///     user description data
    /// </summary>
    public class User:IEntity
    {
        /// <summary>
        ///     user details id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        ///     tenant id
        /// </summary>
        public Guid TenantId { get; set; }

        /// <summary>
        ///     user role 
        /// </summary>
        public ICollection<UserRoles> Role { get; set; }

        /// <summary>
        ///     user interests
        /// </summary>
        public ICollection<Interest> UserInterests { get; set; }

        /// <summary>
        ///     user activity
        /// </summary>
        public bool Deleted { get; set; }
    }
}