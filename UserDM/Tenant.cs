namespace UserDM
{
    public class Tenant
    {
        /// <summary>
        ///  tenant ID (tenant users group)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  tenant name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  tenant account creation date
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}