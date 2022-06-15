using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.DTO
{
    /// <summary>
    /// DTO that is used to recieve an user from the client.
    /// </summary>
    public class UserDTO : BaseDTO
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string GoogleId { get; set; }
    }
}
