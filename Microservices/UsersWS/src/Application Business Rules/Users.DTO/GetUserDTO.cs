namespace Users.DTO
{

    /// <summary>
    /// DTO that is used to return a user to the client.
    /// </summary>
    public class GetUserDTO : BaseDTO
    {
        public string UserId { get; set; }

    }
}