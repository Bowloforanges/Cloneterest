namespace Users.DTO
{

    /// <summary>
    /// DTO that is used to recieve an user from the client.
    /// </summary>
    public class CreateOrUpdateUserDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GoogleId { get; set; }
    }
}
