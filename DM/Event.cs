using MongoDB.Bson.Serialization.Attributes;

namespace DM.Models
{
    /// <summary>
    ///     event description
    /// </summary>
    public class Event
    {
        /// <summary>
        ///     event id
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        ///     event date begin
        /// </summary>
        public DateTime DateBegin { get; set; }

        /// <summary>
        ///     event date end
        /// </summary>
        public DateTime DateEnd { get; set; }

        /// <summary>
        ///     event name
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        ///     event description
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        ///     event date create
        /// </summary>
        public DateTime DateCreate { get; set; } = DateTime.Today;

        public virtual ICollection<Person> EventMembers { get; set; } = new HashSet<Person>();
    }
}