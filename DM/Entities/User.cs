﻿using UserDM.Enums;

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
        /// user contact information id
        /// </summary>
        public Guid UserDataId { get; set; }

        /// <summary>
        /// user data entity
        /// </summary>
        public virtual UserData UserData { get; set; }

        /// <summary>
        ///     user role 
        /// </summary>
        public UserRoles Roles { get; set; }

        /// <summary>
        ///     user interests
        /// </summary>
        public virtual ICollection<Interest> UserInterests { get; set; }
                
        /// <summary>
        ///     found companion
        /// </summary>
        public virtual Companion Companion{ get; set; }

        /// <summary>
        /// pair id
        /// </summary>
        public Guid PairId { get; set; }    

        /// <summary>
        ///     user activity
        /// </summary>
        public bool Deleted { get; set; }
    }
}