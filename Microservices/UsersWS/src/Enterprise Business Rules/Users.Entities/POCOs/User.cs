namespace Users.Entities.POCOs
{

    /// <summary>
    /// POCO file that describes the user business concept
    /// </summary>
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GoogleId { get; set; }
    }
}
