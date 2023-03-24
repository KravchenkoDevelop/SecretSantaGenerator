using DM.Entities;

namespace DM
{
    public class Tenant:IEntity
    {
        /// <summary>
        ///  tenant ID (tenant users group)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  tenant account creation date
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;

        /// <summary>
        ///  users entiti
        /// </summary>
        public virtual ICollection<User> Users { get; set; }
    }
}