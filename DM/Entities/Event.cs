using DM.Entities;

namespace DM
{
    /// <summary>
    ///     event description
    /// </summary>
    public class Event:IEntity
    {
        /// <summary>
        ///     event id
        /// </summary>

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
        public string Description { get; set; }

        /// <summary>
        ///     event date create
        /// </summary>
        public DateTime DateCreate { get; set; } = DateTime.Today;

    }
}