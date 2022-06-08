using System.Collections.Generic;
using System.Threading.Tasks;
using Users.Entities.POCOs;

namespace Users.Entities.Interfaces
{

    /// <summary>
    /// Repository pattern interface that describes database operations for the user business concept.S
    /// </summary>
    public interface IUserRepository
    {
        //Get specific user
        Task<User> GetUserAsync(string userId);

        //Get all users
        Task<IEnumerable<User>> GetAllUserAsync();

        //Create user
        Task CreateUserAsync(User user);

        //Update user
        Task UpdateUserAsync(string userId, User user);

        //Create user
        Task CreateUserAsync(string userId);

    }
}
