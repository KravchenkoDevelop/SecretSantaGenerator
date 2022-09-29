using UserDM.Enums;

namespace DM
{
    /// <summary>
    ///     user description data
    /// </summary>
    public class User
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
        /// tenant entity
        /// </summary>
        public virtual Tenant Tenant { get; set; }
                
        /// <summary>
        ///     user role 
        /// </summary>
        public UserRoles Role { get; set; }

        /// <summary>
        ///     user interests
        /// </summary>
        public virtual ICollection<Interest> UserInterests { get; set; }

        /// <summary>
        ///     user activity
        /// </summary>
        public bool Deleted { get; set; }
    }
}