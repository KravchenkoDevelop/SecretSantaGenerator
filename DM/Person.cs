namespace DM.Models
{
    /// <summary>
    ///     person description
    /// </summary>
    public class Person
    {
        /// <summary>
        ///     person id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     person fio
        /// </summary>
        public string Fio { get; set; }

        /// <summary>
        ///     person e-mail
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        ///     person living country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        ///     person living  region
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        ///     person living city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///     person address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     person PostalCode
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        ///     person interests
        /// </summary>
        public virtual ICollection<Interest> PersonInterests { get; set; } = new HashSet<Interest>();

        /// <summary>
        ///     binding person and event
        /// </summary>
        public virtual Event EventMembership { get; set; }

        /// <summary>
        ///     event membership id
        /// </summary>
        public Guid EventId { get; set; }

        /// <summary>
        ///     found companion
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        ///     person activity
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        ///     tenant binding with user 
        /// </summary>
        public virtual Tenant Tenant { get; set; }

        /// <summary>
        ///     tenant id
        /// </summary>
        public Guid TenantId { get; set; }
    }
}