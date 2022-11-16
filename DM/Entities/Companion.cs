using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
    /// <summary>
    /// gift giver gift reciever pair
    /// </summary>
    public class Companion
    {
        /// <summary>
        ///  pair id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// gift giver entity
        /// </summary>
        public virtual User GiftGiver { get; set; }

        /// <summary>
        /// gift giver id
        /// </summary>
        public Guid GiftGiverId { get; set; }

        /// <summary>
        /// gift reciever entity
        /// </summary>
        public virtual User GiftAcceptor { get; set; }

        /// <summary>
        /// gift reciever id
        /// </summary>
        public Guid GiftAccceptorId { get; set; }

        /// <summary>
        /// event entity
        /// </summary>
        public virtual Event Event { get; set; }

        /// <summary>
        /// event id
        /// </summary>
        public Guid EventId { get; set; }
    }
}
