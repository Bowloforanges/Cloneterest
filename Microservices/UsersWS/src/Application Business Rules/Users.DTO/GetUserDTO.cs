using System;

namespace Users.DTO
{

    /// <summary>
    /// DTO that is used to return a user to the client.
    /// </summary>
    public class GetUserDTO : BaseDTO
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GoogleId { get; set; }
    }
}
