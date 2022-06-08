using System;

namespace Users.DTO
{

    /// <summary>
    /// DTO that is used to receive a user id from the client.
    /// </summary>
    public class DeleteUserDTO : BaseDTO
    {
        public string UserId { get; set; }
    }
}
